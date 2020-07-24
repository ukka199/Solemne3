using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
public class PruebaServicio : IPruebaServicio
{
    int IPruebaServicio.Modulo(int value1, int value2)
    {
		if (value1 >= value2)
		{
			if (value2 == 0)
			{
				return -1;
			}
			else
			{
				return value1 % value2;
			}
		}
		else
		{
			if (value1 == 0)
			{
				return -1;
			}
			else
			{
				return value2 % value1;
			}
		}
	}
}