﻿//
//  EmptyClass.cs
//
//  Author:
//       havoc <>
//
//  Copyright (c) 2016 havoc
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
using System;
using System.IO;
using System.Diagnostics;

namespace EasyCrypt
{
	public class SysFicheros
	{

		public static string RUTA_MIPC = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);
		public static string RUTA_EJECUTABLE = System.Windows.Forms.Application.ExecutablePath;
		public static string RUTA_DIR_APP = Path.GetDirectoryName(RUTA_EJECUTABLE);

		public SysFicheros()
		{
		}

		public bool borrarFichero(string strFichero)
		{
			try {
				if (File.Exists(strFichero)) {
					File.Delete(strFichero);
				}
			} catch (Exception ex) {
				Console.WriteLine(ex.Message);
				return false;
			}
			return true;
		}

		public bool tieneDatos(string strFichero)
		{
			return (new FileInfo(strFichero).Length > 0);
		}

		public string quitaExtension(string strFichero)
		{
			return Path.GetFileNameWithoutExtension(strFichero);
		}

		public string getExtension(string strFichero)
		{
			return Path.GetExtension(strFichero);
		}

		public bool existeFichero(string fichero)
		{
			return File.Exists(fichero);
		}

		public bool existeDirectorio(string ruta)
		{
			return Directory.Exists(ruta);
		}

		public string combinarRuta(string strDirectorio, string strFichero)
		{
			return Path.Combine(strDirectorio, strFichero);
		}

		public void ejecutar(string strEjecutable)
		{
			Process proceso = new Process(strEjecutable).Start();
		}
	}
}

