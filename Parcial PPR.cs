using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Parcial {

    string[] names;
    double[] data;


    public Parcial(string[] _names, double[] _data) {
        data = new double[_data.Length];
        _data.CopyTo(data, 0);
        names = new string[_names.Length];
        _names.CopyTo(names, 0);
    }


    public int PrimerPunto() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);

        int salida = 0 ;
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------
        double media=0, dE = 0;
        int numEst=0;

        for (int i=0; i < notas.Length; i++)
        {
            media = media + notas[i];
        }
        media = media / notas.Length;

        for (int i=0; i < nombres.Length; i++)
        {
            dE = dE + Math.Pow((notas[i] - media), 2);
        }
        dE = Math.Sqrt(dE / notas.Length);
        Console.WriteLine("media: " + media + "\nDesviación Est: " + dE);

        for (int i=0; i < nombres.Length; i++)
        {
            if (notas[i] >= media + dE) { numEst++; }
        }
        salida = numEst;
        
        

        //- Arriba de esta línea va su código --------
        return salida;
    }

    public string[] SegundoPunto() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);

        string[] salida = new string[5];
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------

        string tmpNom;
        double tmpNot;
        double media = 0;
        double[] dE = new double[nombres.Length];

        for (int i = 0; i < notas.Length; i++)
        {
            media = media + notas[i];
        }
        media = media / notas.Length;

        for (int i = 0; i < nombres.Length; i++)
        {
            dE[i] = Math.Sqrt(((Math.Pow((notas[i] - media), 2))/nombres.Length));
        }

        for (int s = 0; s < nombres.Length - 1; s++)
        {
            for (int i = 0; i < nombres.Length - 1; i++)
            {
                if (dE[i + 1] > dE[i])
                {
                    tmpNom = nombres[i];
                    tmpNot = dE[i];
                    nombres[i] = nombres[i + 1];
                    nombres[i + 1] = tmpNom;
                    dE[i] = dE[i + 1];
                    dE[i + 1] = tmpNot;

                }
            }
        }
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("\nNombre: " + nombres[i]);
            Console.WriteLine("Notas: " + dE[i]);
            salida[i] = nombres[i];
        }

        //- Arriba de esta línea va su código --------
        return salida;
    }

    public string[] TercerPunto() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);
        string[] salida = new string[0];
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------
        double media = 0, dE = 0;

        for (int i = 0; i < notas.Length; i++)
        {
            media = media + notas[i];
        }
        media = media / notas.Length;

        for (int i = 0; i < nombres.Length; i++)
        {
            dE = dE + Math.Pow((notas[i] - media), 2);
        }
        dE = Math.Sqrt(dE / notas.Length);

        for (int i = 0; i < notas.Length; i++)
        {
            if (notas[i] >= media + dE)
                {
                    salida[i] = nombres[i];
                }
        }
    

        //- Arriba de esta línea va su código --------
        return salida;
    }

    public string[] CuartoPunto() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);

        string[] salida = new string[0];
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------


        //- Arriba de esta línea va su código --------
        return salida;
    }

    public List<string> TercerPuntoListas() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);
        List<string> salida = new List<string>();
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------
        
        

        //- Arriba de esta línea va su código --------
        return salida;
    }

    public List<string> CuartoPuntoListas() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);
        List<string> salida = new List<string>();
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------
        


        //- Arriba de esta línea va su código --------
        return salida;
    }
}


