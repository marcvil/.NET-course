// JavaScript source code


    
const int arrayLength = 40;
string[] Letras = new string[arrayLength];
Letras[0] = "M";
Letras[1] = "a";
Letras[2] = "r";
Letras[3] = "c";
Letras[4] = "";
Letras[5] = "V";
Letras[6] = "i";
Letras[7] = "l";
Letras[8] = "à";

int i = 0;

for (i = 0; i <= Letras.Length; i++)
{
    Console.WriteLine(Letras[i]);

    if (Letras[i] == null)
    {
        return;
    }
}


            Console.ReadKey();
    
