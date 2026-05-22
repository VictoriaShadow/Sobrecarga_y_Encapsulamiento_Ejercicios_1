using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio1_SimuladorDeAutomovil
{
    public class Automovil
    {
        private string _marca;
        private bool _motorEncendido;
        private int _velocidadActual;
        private bool _cajaAutomatica;
        private bool _modoCrucero;
        public string Marca
        {
            get { return _marca; }
            set
            {
                if (value != null)
                    _marca = value;
            }
        }
        public bool MotorEncendido
        {
            get { return _motorEncendido; }
            set
            {
                if (MotorEncendido == true)
                {
                    Console.WriteLine("Motor Encendido");
                } else
                {
                    Console.WriteLine("Motor Apagado");
                }
            }
        }
        public int VelocidadActual
        {
            get { return _velocidadActual; }
            set
            {
                if (value >= 0)
                {
                    _velocidadActual = value;
                }
            } }
        public bool CajaAutomatica
        {
            get { return _cajaAutomatica; }
            set { }
        }
        public bool ModoCrucero
        {
            get { return _modoCrucero; }
            set
            {
                if (MotorEncendido == true)
                {
                    _modoCrucero = value;
                    Console.WriteLine("Ingresando a modo crucero....");
                    Console.WriteLine("Se ah ingresado al modo crucero");
                } else
                {
                    Console.WriteLine("No se puede entrar al modo crucero con el automovil apagado");
                }
            }
        }
        public string Identificador {
            get {
                string identificador = "";
                identificador += _marca.Substring(0, 3).ToUpper();
                if (_cajaAutomatica == true)
                {
                    identificador += "-AUTO-";
                }
                else
                {
                    identificador += "-MAN-";
                }
                identificador += DateTime.Now.Year;
                return identificador;
            } 
        }
        public void EncenderApagar()
        {
            if (_motorEncendido == false)
            {
                _velocidadActual = 0;
            }
        }
        public void Acelerar(int km)
        {
            if (_motorEncendido == true)
            {
               _velocidadActual += km;
            } else
            {
                Console.WriteLine("No se puede acelerar con el motor apagado");
            }
        }
        public void Acelerar()
        {
            if (_motorEncendido == true)
            {
                _velocidadActual = 10;
            }
            else
            {
                Console.WriteLine("No se puede acelerar con el motor apagado");
            }
        }
        public void Frenar(int km)
        {
            _velocidadActual -= km;
            if (_motorEncendido == true)
            {
            if (_velocidadActual < 0) {
                _velocidadActual = 0; }
            }
            else
            {
                Console.WriteLine("No se puede frenar con el motor apagado");
            }
        }
        public void Frenar()
        {
            if (_motorEncendido == true)
            {
            _velocidadActual = 0;
            }
            else
            {
                Console.WriteLine("No se puede frenar con el motor apagado");
            }
        }
    }
}
