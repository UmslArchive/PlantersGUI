#include <SPI.h>
#include <SD.h>

const int chipSelect = 4;                         //Selected pin for SD card read.
int motorPin = A0;                                //Pin that turns on the motor.
int blinkPin = 13;                                //Pin that turns on the LED.
int soilPin = A1;                                 //Declare a variable for the soil moisture sensor.
int soilPower = 7;                                //Variable for Soil moisture Power.

int watertime = 5;                                //How long to water in seconds.
int waittime = 1;                                //How long to wait between watering in minutes.

int sensorValue = 0;                              //Value for storing moisture value.
int moistureLevelHolder = 0;                      //Value hold for calculation.
int moistureInterval = 0;                         //Help calculate our average moisture levels.
int averageMoistureLevel = 0;                     //Average moisture of current experiment.
int moistureIntervals = 0;

//-------------------------------------------------------------------------------------------------------
void setup() 
{
  Serial.begin(9600);                             // open serial over USB.
  while (!Serial) 
  {
    ; //Wait for serial port to connect. Needed for native USB port only
  }

  Serial.print("Initializing SD card...");        //See if the card is present and can be initialized.
  
  if (!SD.begin(chipSelect))                      //Error handling for SD card.
  {
    Serial.println("Card failed, or not present");
    // don't do anything more.
    while (1);
  }
  Serial.println("card initialized.");

  pinMode(soilPower, OUTPUT);                     //Set D7 as an OUTPUT.
  digitalWrite(soilPower, LOW);                   //Set to LOW so no power is flowing through the sensor.

  pinMode(motorPin, OUTPUT);                      //Set A0 to an output so we can use it to turn on the transistor.
  pinMode(blinkPin, OUTPUT);                      //Set pin 13 to an output so we can use it to turn on the LED.
}

void loop() 
{  
  String moistureLog = "";                        //Make a string for assembling the data to log.
  String averageMoistureLog = "";
  int sensor = analogRead(soilPin);               //Read Moisture sensors and append to the string.
  moistureLog += String(sensor);
  averageMoistureLog += String(averageMoistureLevel);

  //Open the file. note that only one file can be open at a time,
  //So you have to close this one before opening another.
  File dataFile = SD.open("datalog.txt", FILE_WRITE);

  //If the file is available, write to it.
  if(dataFile)                                  //Output to datalog.txt.
  {
    dataFile.print("Soil Moisture: " + moistureLog + " | Average value: " + averageMoistureLog);
    dataFile.println();
    dataFile.close();
  }
  else 
  {
    Serial.println("error opening datalog.txt");  //If the file isn't open, pop up an error.
  }

  //This three second timefrme is used so you can test the sensor and see it change in real-time.
  //For in-plant applications, you will want to take readings much less frequently.
  delay(2000);                                  //take a reading every two second
  
  Serial.print("Soil Moisture = ");
  Serial.println(readSoil());
  //"Average moisture level: " + averageMoistureLevel
  
  if(sensorValue < 1000)                        //Change value on simple testing.
  {
    digitalWrite(soilPower, LOW); //turn D7 "Off"
    Serial.print("Pumping water \n");

    digitalWrite(motorPin, HIGH);               //Turn on the motor.
    digitalWrite(blinkPin, HIGH);               //Turn on the LED.
    delay(watertime * 1000);                    //Multiply by 1000 to translate seconds to milliseconds.

    digitalWrite(motorPin, LOW);                //Turn off the motor.
    digitalWrite(blinkPin, LOW);                //Turn off the LED.
    delay(waittime * 1000);                     //Multiply by 60000 to translate minutes to milliseconds.

    Serial.print("Pumping stopped \n");
  }
}

int readSoil()
{
  digitalWrite(soilPower, HIGH);                  //turn D7 "On".
  delay(100);                                     //wait 100 milliseconds.
  sensorValue = analogRead(soilPin);              //Read the SIG value form sensor.

  //Calculate our average moisture level.
  moistureLevelHolder = averageMoistureLevel + sensorValue; 
  moistureIntervals = moistureIntervals + 1;
  averageMoistureLevel = moistureLevelHolder / moistureIntervals;
  
  return sensorValue;                             //send current moisture value back to loop for SD readings.
}
