using System;
using System.Collections.Generic;
using System.Text;

namespace Practica11_PrincipiosSOLID
{
    public interface IRepositorioEmpleados
    {
        void Guardar(Empleado empleado);
        List<Empleado> ObtenerTodos();
    }
}
