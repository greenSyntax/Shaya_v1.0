#include <Servo.h>
#include <SPI.h>
#include <Ethernet.h>

/*

******************************************************

====== SHYA v.1.0.0 (APLHA)===========================

Version: v1.0.0
Starting Date: 21st April 2015
Last Modified Date: 21st April 2015
Time: 4:00AM

Author: Abhishek Kumar Ravi (@greenSyntax)
GitHub: http://github.com/greenSyntax
Facebook: http://facebook.com/elmnt.abhishek
Twitter: @greenSyntax
------------------------------------------------------
DESCRIPTION

SPECIFICATION
LED 1 #PIN 8
LED 2 #PIN 12

LED RED #PIN 7
LED GREEN #PIN 4 

BUZZER #PIN ~10

SERVO (Yellow) #PIN2

******************************************************

*/

int bulbFirst= 8;
int bulbSecond= 12;
int ledRed= 7;
int ledGreen= 4;
int buzzer= 9;


static int state_bulb_first=0; //off
static int state_bulb_second=0; //off
static int state_door=0;// closed
static int state_bell=0; // No Sound

// Instances
Servo servo;
int pos; 

void setup() {
  // Baud Rate is 9600 (Defualt)
  Serial.begin(9600);
  
  
  pinMode(bulbFirst, OUTPUT);
  pinMode(bulbSecond, OUTPUT);
  pinMode(ledRed, OUTPUT);
  pinMode(ledGreen, OUTPUT);
  pinMode(buzzer, OUTPUT);
  
  //Servo
  servo.attach(2); //PIN 2
  
  
  //Default Cases
  Serial.flush(); // Flush Memory
  digitalWrite(ledRed, HIGH);
  
  //int num= 01/10;
  //String myString=String(num);
  //Serial.println(myString);
  
  //Bluetooth HC-05
  
  
}

void loop() {
  // put your main code here, to run repeatedly:
  
  if(Serial.available()>0)
  {
    char choice= Serial.read(); //Ask From SerialMonitor 
    //String choice= String(input);
    
    
    //Decision Panel
    switch(choice)
    {
      //==============================================================
      // ******************* BULB - FIRST ***************************
      //--------------------------------------------------------------
      case '9': // # BULB-1 ON #
      
      Serial.println(">> Case 1: Light-ON BULB-1");
      if(LightBulb_First()==1)
      {
        //Successfully Lighted UP
        Serial.println("# BULB-1 is ON #");
        
      }
      else
      {
        //Unssucessfull Return ()
        Serial.println("# Error for BULB-1 #");
      }
      break;
      
      case '2': // # BULB-1 OFF #
      Serial.println(">> Case 2: Ligh-OFF BULB-2");
      digitalWrite(bulbFirst, LOW);
      state_bulb_first=0; // Bulb-1 Off
      break;
      //================================================================
      
      
      //==============================================================
      // ******************* BULB - FIRST ***************************
      //--------------------------------------------------------------
      case '3': // # BULB-2 ON #
      Serial.println(">> Case 3: Light-ON BULB-2");
      if(LightBulb_Second()==1)
      {
        
        //Successfully Lighted UP
        Serial.println("# BULB-2 is ON #");
      }
      else
      {
        //Unssucessfull Return ()
        Serial.println("# Error for BULB-2 #");
      }
      break;
      
      case '4': // # BULB-2 OFF #
      Serial.println(">> Case 4: Ligh-OFF BULB-2");
      digitalWrite(bulbSecond, LOW);
      state_bulb_second=0; // Bulb-1 Off
      break;
      //================================================================
      
      //================================================================
      case '5': //Buzzer
      BuzzerBeep(200);
      Serial.println(">> Case 5: Pop Buzzer");
      break;
      //=================================================================
      
      // ================================================================
      
      case '6': //Open Door
      Serial.println(">> Case 6: Open Door");
      OpenDoor();
      Serial.println(">> Successfully");
      break;
      //=================================================================
      // ================================================================
      
      case '7': //Close Door
      Serial.println(">> Case 7: Close Door");
      CloseDoor();
      Serial.println(">> Successfully");
      break;
      //=================================================================
    }
    
    Serial.println("*END*");
  }
  
}

int LightBulb_First()
{
  //Only when, Bulb is OFF
  if(state_bulb_first == 0) 
  {
    //Will LIGHT Bulb : ON
    digitalWrite(bulbFirst,HIGH);
    Serial.println("# Called Light() BULB-1");
    state_bulb_first= 1;
    
    return 1; // Successfully Lighted Up
  }
  else
  {
    Serial.println("# Called No-Light() BULB-1 ");
    return 0; //Unsuccessfull
  }
  
}

int LightBulb_Second()
{
  //Only when, Bulb is OFF
  if(state_bulb_second == 0) 
  {
    //Will LIGHT Bulb : ON
    digitalWrite(bulbSecond,HIGH);
    Serial.println("# Called Light() BULB-2");
    state_bulb_second= 1;
    
    return 1; // Successfully Lighted Up
  }
  else
  {
    Serial.println("# Called No-Light() BULB-2 ");
    return 0; //Unsuccessfull
  }
}

void BuzzerBeep(unsigned char delayTime)
{
  analogWrite(buzzer,20);// TURN ON
  delay(delayTime);
  analogWrite(buzzer,20); //TURN OFF
  delay(delayTime);
  analogWrite(buzzer,0);
}

void OpenDoor() // OPEN DOOR
{
  // LED + SERVO
  if(state_door==0) // So, We 'll OPEN Door
  {
    Serial.println("# DOOR OPEN + GREEN LED");
    digitalWrite(ledRed, LOW); //OFF LED RED
    digitalWrite(ledGreen, HIGH); //LED GREEN
    
    //Servo Rotate
    for(pos = 0; pos <= 180; pos += 1) // goes from 0 degrees to 180 degrees 
      {                                  // in steps of 1 degree 
        servo.write(pos);              // tell servo to go to position in variable 'pos' 
        //delay(15);                       // waits 15ms for the servo to reach the position 
      } 
    
    state_door=1;
  }
  else
  {
    Serial.println("# DOOR ALREADY OPEN ");
  }
}

void CloseDoor()
{
  // LED + SERVO
  if(state_door==1) // So, We 'll CLOSE Door
  {
    Serial.println("# DOOR CLOSE + GREEN LED");
    digitalWrite(ledGreen, LOW); // GREEN LED LOW
    digitalWrite(ledRed, HIGH); //LED GREEN
    
    // Servo Close
        for(pos = 180; pos>=0; pos-=1)     // goes from 180 degrees to 0 degrees 
          {                                
            servo.write(pos);              // tell servo to go to position in variable 'pos' 
            //delay(15);                       // waits 15ms for the servo to reach the position 
          } 
    
    state_door=0;
  }
  else
  {
    Serial.println("# DOOR ALREADY CLOSE ");
  }
}


