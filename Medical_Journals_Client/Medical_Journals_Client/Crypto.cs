using System;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Medical_Journals_Client.Utilities
{
    public class Crypto
    {
            //Llamada al proveedor de encriptados 3DES


            private TripleDESCryptoServiceProvider m_des = new TripleDESCryptoServiceProvider();
            // Define en controlador de cadenas de texto


            private UTF8Encoding m_utf8 = new UTF8Encoding();
            // Propiedades de los arrays


            private byte[] m_key;

            private byte[] m_iv;
            //Llave local y vector de bytes

            private readonly byte[] key = {
            1,
            2,
            3,
            4,
            5,
            6,
            7,
            8,
            9,
            10,
            11,
            12,
            13,
            14,
            15,
            16,
            17,
            18,
            19,
            20,
            21,
            22,
            23,
            24

        };
            private readonly byte[] iv = {
            43,
            16,
            44,
            12,
            56,
            10,
            41,
            14
		    // Cambiar los valores numéricos por unos diferentes ya que es parte de la llave de codificación y decodificación.
	    };

            public Crypto()
            {
                this.m_key = key;

                this.m_iv = iv;

            }

            public byte[] Encriptar(byte[] input)
            {
                return Transformar(input, m_des.CreateEncryptor(m_key, m_iv));
            }

            public byte[] Desencriptar(byte[] input)
            {
                return Transformar(input, m_des.CreateDecryptor(m_key, m_iv));
            }

            // FUNCION PARA ENCRIPTAR

            public string Encriptar(string text)
            {

                byte[] input = m_utf8.GetBytes(text);

                byte[] output = Transformar(input, m_des.CreateEncryptor(m_key, m_iv));

                return Convert.ToBase64String(output);

            }

            // FUNCION PARA DESENCRIPTAR

            public string Desencriptar(string text)
            {

                byte[] input = Convert.FromBase64String(text);

                byte[] output = Transformar(input, m_des.CreateDecryptor(m_key, m_iv));

                return m_utf8.GetString(output);

            }

            private byte[] Transformar(byte[] input, ICryptoTransform CryptoTransformar)
            {

                // Crea los streams necesarios

                MemoryStream memStream = new MemoryStream();

                CryptoStream cryptStream = new CryptoStream(memStream, CryptoTransformar, CryptoStreamMode.Write);

                //transforma la peticion en bytes

                cryptStream.Write(input, 0, input.Length);

                cryptStream.FlushFinalBlock();

                // Lee la posicion de memoria y lo convierte en arreglo de bytes

                memStream.Position = 0;

                byte[] result = new byte[Convert.ToInt32(memStream.Length - 1) + 1];

                memStream.Read(result, 0, Convert.ToInt32(result.Length));

                // Libera y cierra los streams

                memStream.Close();

                cryptStream.Close();

                return result;

            }
        
    
}
}

