
#include <iostream>
#include <unistd.h> 
#include <stdio.h> 
#include <sys/socket.h> 
#include <stdlib.h> 
#include <netinet/in.h> 
#include <string.h> 
#include <wiringPi.h>
#include <arpa/inet.h>
#include <wiringPiI2C.h>

#define TOUCH 0xCE
#define RELEASE 0xCA

using namespace std;


int main()
{
	

	//Préparation des capteurs

	int fd = wiringPiI2CSetup(0x5A);
	if (fd == -1) printf("erreur fd\n");

	//soft reset
	wiringPiI2CSetup(fd, 0x80, 0x63);
	delay(1);

	//ECR: réglage des capteurs

	wiringPiI2CWriteReg8(fd, 0x5E, 0x4A);
	printf("reg 0x5D (config2=24?) : %d\n", wiringPiI2CReadReg8(fd, 0x5D));

	wiringPiI2CWriteReg8(fd, 0x41, TOUCH);
	wiringPiI2CWriteReg8(fd, 0x42, RELEASE);
	wiringPiI2CWriteReg8(fd, 0x47, TOUCH);
	wiringPiI2CWriteReg8(fd, 0x48, RELEASE);




	//Attacher le socket à une adresse IP et un port

	int socket_in =socket(AF_INET, SOCK_DGRAM, 0);
	sockaddr_in server;
	server.sin_addr.s_addr = INADDR_ANY; //accepte toutes les adresses
	server.sin_family = AF_INET;
	server.sin_port = htons(54000); //Conversion little to big endian

	if (bind(socket_in, (sockaddr*)&server, sizeof(server)) == -1)
	{
		cout << "Erreur pas de bind !!" << errno << endl;

	}

	else {
		cout << "Bind correct" << endl;
	}

	//Information du client

	sockaddr_in client;
	client.sin_family = AF_INET;
	client.sin_port = htons(54000);
	socklen_t clientlenght = sizeof(client);
	int message_test[1];

	//Boucle d'attente

	while (true)
	{
		
		int bit_recu = recvfrom(socket_in, message, 1024, 0, (sockaddr*)&client,&clientlength);
		if (bit_recu == -1)
		{
			cout << "Error receiving from client" << errno << endl;
			continue;
		}


		//Affichage du message et les infos du client

		char Ip_du_client[256];

		inet_ntop(AF_INET, &client.sin_addr, Ip_du_client, 256);

		cout << "Message reçu de la part de " << Ip_du_client << endl;
		inet_pton(AF_INET, "Ip_du_client", &client.sin_addr);



		// Valeur du capteur

		if (bit_reçu != -1) {

			while (true) {
				printf("Reg 0x00: %d\n", wiringPiI2CReadReg8(fd, 0x00));
				message_test[0] = wiringPiI2CReadReg8(fd, 0x00);
				delay(1000);



		//envoi des valeurs lues par le capteur

				int octets_envoyes = sendto(socket_in, message_test, sizeof(message_test), 0, (sockaddr*)&client, sizeof(client));

				cout << "Message envoyé:" << message_test << endl;
				message_test[0]= 42 //jamais envoyé 

					if (octets_envoyes == -1) {
						cout << "Quelque chose dans l'envoie n'a pas fonctionné " << endl;
				}
			}
		}
	
	}

	//Fermeture du socket

	close(socket_in);



	return 0;
}


