package com.comp231.saju.mobilewallet;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Log;

import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.OutputStreamWriter;
import java.net.Socket;

public class MainActivity extends AppCompatActivity {
    private static final String hostname = "localhost";
    private static final int portnumber = 60123;
    private static final String debugString = "debug";

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        Socket socket = null;
        try{
            Log.i(debugString,"Attempting to connect to server");
            socket = new Socket(hostname, portnumber);
            Log.i(debugString,"Connection Established");

            BufferedWriter bw = new BufferedWriter(new OutputStreamWriter(socket.getOutputStream()));
            bw.write("This is a message from the server");
            bw.newLine();
            bw.flush();

            BufferedReader br = new BufferedReader(new InputStreamReader(socket.getInputStream()));
            System.out.println("Message from client : "+br.readLine());

        }catch(IOException e){
            Log.e(debugString, e.getMessage());
        }

    }
}
