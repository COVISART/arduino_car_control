#include <SoftwareSerial.h>
SoftwareSerial BT(3, 2); 
// connect BT module TX to D3
// connect BT module RX to D2
// connect BT Vcc to 5V, GND to GND

void setup()  
{
  // set digital pin to control as an output
  pinMode(13, OUTPUT);
  pinMode(12, OUTPUT);
  pinMode(11, OUTPUT);
  pinMode(10, OUTPUT);
  // set the data rate for the SoftwareSerial port
  BT.begin(9600);
  // Send test message to other device
  BT.println("Hello from Arduino");
}
char a; // stores incoming character from other device
void loop() 
{
  if (BT.available())
  // if text arrived in from BT serial...
  {
    a=(BT.read());
    if (a=='w')
    {
      digitalWrite(13, HIGH);
      digitalWrite(12, LOW);
      digitalWrite(11, HIGH);
      digitalWrite(10, LOW);
      digitalWrite(4, LOW);
    }
    if (a=='s')
    {
      digitalWrite(13, LOW);
      digitalWrite(12, HIGH);
      digitalWrite(11, LOW);
      digitalWrite(10, HIGH);
    }
    if (a=='a')
    {
      digitalWrite(12, HIGH);
      digitalWrite(13, LOW);
      digitalWrite(11, HIGH);
      digitalWrite(10, LOW);
    }
    if (a=='d')
    {
      digitalWrite(13, HIGH);
      digitalWrite(12, LOW);
      digitalWrite(11, LOW);
      digitalWrite(10, HIGH);
    }
    if (a=='l')
    {
       digitalWrite(4, HIGH);
    }   
    if (a=='o')
    {
       digitalWrite(4, LOW);
    }
    // you can add more "if" statements with other characters to add more commands
  }
}
