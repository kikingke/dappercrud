using CDatos;
using CEntities;
using System.Collections.Generic;
using System.Linq;

namespace CNegocio
{
    public class NCliente
    {
        private DCliente objCliente = new DCliente();

        public List<Cliente> GetClientes()
        {
                return objCliente.GetClientes();
        }

        public List<Cliente> GetClientesActivos()
        {
            return objCliente.GetClientesActivos();
        }

        public List<Cliente> GetClientesInactivos()
        {
            return objCliente.GetClientesInactivos();
        }

        public int AddCliente(Cliente cliente)
        {
            return objCliente.AddCliente(cliente);
        }

        public int EditCliente(Cliente cliente)
        {
            return objCliente.UpdateCliente(cliente);
        }

        public int DeleteCliente(Cliente cliente)
        {
            return objCliente.DeleteCliente(cliente);
        }

        public int GetTotalAmountOfClientes()
        {
            return objCliente.GetTotalCount();
        }


    }
}
