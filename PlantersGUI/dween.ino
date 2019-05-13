int moistureSensorValue;
String currentState;
int constraint = -1;

void await(String what)
{
  while(Serial.available() <= 0)
  {
      Serial.println("Awaiting " + what + ".");
  }
}

void flushInput()
{
  while(Serial.read() >= 0) ;
}

void setup() 
{
  //Initialize serial communication at 9600 bits per second:
  Serial.begin(9600);
  
  //Wait for serial port to connect.
  while(!Serial)
  {
    ;
  }

  //Readin constraints.
  await("constraint");
  constraint = Serial.parseInt();
  flushInput();
}

void loop() 
{  
  //Get sensor readings.
  moistureSensorValue = analogRead(A0);

  //Build state string.
  currentState = (String)(moistureSensorValue);
  Serial.flush();
  Serial.println(currentState);
  delay(100);
}
