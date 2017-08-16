package com.company;

// import scanner class for input
import java.util.Scanner;

public class Main {

    public static void main(String[] args)
    {
        // create new scanner object
	    Scanner keyboard = new Scanner(System.in);

	    // give instruction
        System.out.println("Enter a sentence and I will reverse it!");

        // create variable to hold input
        String input = keyboard.nextLine();

        // split input string
        String [] tokens = input.split(" ");

        // create stringbuffer object
        StringBuilder sb = new StringBuilder();

        // for loop to manipulate string
        for (int index = tokens.length-1; index >-1; index --)
        {
            sb.append(tokens[index]);
            sb.append(" ");
        }

        // display new string
        System.out.println(sb);
    }
}
