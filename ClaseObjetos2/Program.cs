using ClaseObjetos2.ClaseHijo;

Nintendo nintendo = new Nintendo();
nintendo.anioLanzamiento = 2017;
nintendo.esPortable = true;
nintendo.Marca = "Switch";

Console.WriteLine(nintendo.MostrarDetalleNintendo());

//instancia de ps1
Playstation ps = new Playstation();
ps.Marca = "PlayStation 1";
ps.anioLanzamiento = 1994;
ps.ModeloControlador = "DualShock";

Console.WriteLine(ps.MostrarDetallePlay());

Xbox xbox = new Xbox();
xbox.Marca = "Xbox 360";
xbox.anioLanzamiento = 1994;
xbox.Kinect = true;

Console.WriteLine(xbox.MostrardetalleXbox());

Dreamcast dream = new Dreamcast();
dream.Marca = "Sega Dreamcast";
dream.anioLanzamiento = 1994;
dream.Pantallita = true;

Console.WriteLine(dream.Mostrardetalledreamcast());