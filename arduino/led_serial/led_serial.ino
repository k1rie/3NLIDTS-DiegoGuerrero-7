void setup() {
  Serial.begin(9600);
  pinMode(13, OUTPUT);
}

void loop() {
  if (Serial.available()) {
    char c = Serial.read();
    if (c == 'a') digitalWrite(13, HIGH);
    if (c == 'b') digitalWrite(13, LOW);
  }
}
