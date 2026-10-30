using System.Collections.Generic;

namespace Practica11_PrincipiosSOLID
{
    public class RepositorioEmpleadosMemoria : IRepositorioEmpleados
    {
        private readonly List<Empleado> _empleados = new List<Empleado>();

        public void Guardar(Empleado empleado)
        {
            if (empleado != null)
            {
                _empleados.Add(empleado);
            }
        }

        public List<Empleado> ObtenerTodos()
        {
            return _empleados;
        }
    }
}