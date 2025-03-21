﻿using System;
using Spectre.Console;
using SoGoodLib;
namespace LevelTwo
{
    public class Program
    {
        private static void Main(string[] args)
        {   
            
            string message = SoGoodClass.SoGoodMethod();
            Console.WriteLine(message);
        
            
            if(args.Length>0)
            {
            string nome =args[0];
            CanvasImage image=new CanvasImage(nome);

            int tamanho=int.Parse(args[1]);

            image.MaxWidth(tamanho);


            AnsiConsole.Write(image);
            }
            else
            {
            
            CanvasImage image=new CanvasImage("tux.jpg");

           

            image.MaxWidth(24);


            AnsiConsole.Write(image);
            }        
        
        }

    }
}
