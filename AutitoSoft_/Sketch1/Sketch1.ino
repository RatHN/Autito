/*
 Name:		Sketch1.ino
 Created:	9/14/2015 9:19:53 AM
 Author:	Neri Ortez
*/

// the setup function runs once when you press reset or power the board
void setup() {
	TCS3200setup();
	Serial.begin(115200);
	Serial.println("\nReady\n");
	v = 1.0 / 2;
	Serial.println(v);
	delay(2000);

	char m = getChar();
	Serial.println("Calibrar Blanco");
	delay(1000);
	getChar();
	clearInput();
	Cwhite = colorRead(taosOutPin, 0, 1); // Obtener el valor max
	Serial.print("Leido ");
	Serial.print(Cwhite);         // Mostrar el valor max
	Serial.print("\n");
	//Cwhite = (float(_white)/256)*256;
	delay(2000);

	m = getChar();
	Serial.println("Calibrar ROJOJOJOJO");
	getChar();
	clearInput();
	Cred = colorRead(taosOutPin, 1, 1);
	Serial.print("Leido ");
	Serial.print(Cred);
	Serial.print("\n");
	//    Cred = (float(_red)/256)*256;
	//    Serial.print("Factor de Relacion>> ");
	//    Serial.print(Cred); 
	//    Serial.print("\n");
	delay(2000);


	Serial.println("Calibrar AZUUUUUUL, Como el mar AZUL");
	getChar();
	clearInput();
	Cblue = colorRead(taosOutPin, 2, 1);
	Serial.print("Leido ");
	Serial.print(Cblue);
	Serial.print("\n");
	//    Cblue = (float(_blue)/256)*256;
	//    Serial.print("Factor de Relacion>> ");
	//    Serial.print(Cblue);
	//    Serial.print("\n");
	delay(2000);

	Serial.println("Calibrar el color de la yerba");
	getChar();
	clearInput();
	Cgreen = colorRead(taosOutPin, 3, 1);
	Serial.print("Leido ");
	Serial.print(Cgreen);
	Serial.print("\n");
	//    Cgreen= (float(_green)/256)*256;
	//    Serial.print("Factor de Relacion>> ");
	//    Serial.print(Cgreen); 
	//    Serial.print("\n");
	delay(2000);

	/*==================================== SENSOR DOS =================*/
	Serial.println("\n\n Este es para el segundo sensor\n\n\nCalibrar Blanco");
	getChar();
	clearInput();
	Cwhite2 = colorRead(Out2, 0, 1);
	Serial.print("Leido ");
	Serial.print(Cwhite2);
	Serial.print("\n");
	//    Cgreen= (float(_green)/256)*256;
	//    Serial.print("Factor de Relacion>> ");
	//    Serial.print(Cgreen); 
	//    Serial.print("\n");
	delay(2000);

	Serial.println("Calibrar Rojo (2)");
	getChar();
	clearInput();
	Cred2 = colorRead(Out2, 1, 1);
	Serial.print("Leido ");
	Serial.print(Cred2);
	Serial.print("\n");
	//    Cgreen= (float(_green)/256)*256;
	//    Serial.print("Factor de Relacion>> ");
	//    Serial.print(Cgreen); 
	//    Serial.print("\n");
	delay(2000);

	Serial.println("Calibrar AZUL (2)");
	getChar();
	clearInput();
	Cblue2 = colorRead(Out2, 2, 1);
	Serial.print("Leido ");
	Serial.print(Cblue2);
	Serial.print("\n");
	//    Cgreen= (float(_green)/256)*256;
	//    Serial.print("Factor de Relacion>> ");
	//    Serial.print(Cgreen); 
	//    Serial.print("\n");
	delay(2000);

	Serial.println("Calibrar Verde (2)");
	getChar();
	clearInput();
	Cgreen2 = colorRead(Out2, 2, 1);
	Serial.print("Leido ");
	Serial.print(Cgreen2);
	Serial.print("\n");
	//    Cgreen= (float(_green)/256)*256;
	//    Serial.print("Factor de Relacion>> ");
	//    Serial.print(Cgreen); 
	//    Serial.print("\n");
	delay(2000);
}

// the loop function runs over and over again until power down or reset
void loop() {
	if (Serial.available())
	{
		data = Serial.readString(); // Obterner data del PC
		cLinea = data.substring(0, 1);// Data de la linea a seguir
		punto1 = data.substring(1, 1);// Data del punto derecho
		punto2 = data.substring(2, 1);// Data del punto izquierdo
		if (data.substring(2, 1) == "1"){/////////////////////
			adelante = true;			 // Marcha o        //
		}								 //	parada			//
		else adelante = false;			 /////////////////////



		if (adelante) // Si en Marcha....
		{
			// Obtener datos del sensor que sigue linea			
			float detected = detectColor(taosOutPin, Cwhite, Cred, Cblue, Cgreen, cLinea.toInt());
			// Obtener datos del sensor derecho
			float der_percent = detectColor(Out2, Cwhite2, Cred2, Cblue2, Cgreen2, punto1.toInt());
			float der_linea_percent = detectColor(Out2, Cwhite2, Cred2, Cblue2, Cgreen2, cLinea.toInt());
			// Obtener datos del sensor izquierdo
			float izq_percent = detectColor(Out3, Cwhite3, Cred3, Cblue3, Cgreen3, punto2.toInt());
			float izq_linea_percent = detectColor(Out3, Cwhite3, Cred3, Cblue3, Cgreen3, cLinea.toInt());


			if (der_percent < tolerancia && izq_percent < tolerancia){ // Si no se han encontrado los puntos...
				if (der_linea_percent > tolerancia){ // Y si la linea se ha cruzado al a derecha...
					ON(DER);
				}
				else if (der_linea_percent < tolerancia){

				}
			}

			Serial.println("\n");
			Serial.println(detected);
			if (detected >= 95.0){
				Serial.println("Entro");
				pines("00");
			}
		}
		delay(1000);
	}

}
