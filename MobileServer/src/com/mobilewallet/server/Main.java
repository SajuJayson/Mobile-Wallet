/**
 * 
 */
package com.mobilewallet.server;

import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.OutputStreamWriter;
import java.net.ServerSocket;
import java.net.Socket;

/**
 * @author Saju
 *
 */
public class Main {

	/**
	 * @param args
	 */
	private static final int portnumber = 60123;
	public static void main(String[] args) {
ServerSocket serverSocket = null;
try{
	System.out.println("Server starting at port number: "+portnumber);
	serverSocket = new ServerSocket();
	
	System.out.println("waiting for clients to connect.");
Socket socket = serverSocket.accept();

BufferedWriter bw = new BufferedWriter(new OutputStreamWriter(socket.getOutputStream()));
bw.write("This is a message from the client");
bw.newLine();
bw.flush();

BufferedReader br = new BufferedReader(new InputStreamReader(socket.getInputStream()));
System.out.println("Message from server : "+br.readLine());


}
catch(IOException e){
	e.printStackTrace();
}
	}

}
