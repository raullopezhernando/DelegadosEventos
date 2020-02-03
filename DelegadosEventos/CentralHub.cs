using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegadosEventos
{
    public class CentralHub
    {


         public delegate void iniciarProtocoloDelegate();
         iniciarProtocoloDelegate iniciarProtocolo; //Instancia de delegado

        // Tenemos una propiedad para exponer el delegado y poder ir agregandole metodos
        
        

     


        SistemaAlarmas alarmas = new SistemaAlarmas();
        SistemaLuces luces = new SistemaLuces();
        SistemaElectrodomesticos electrodomesticos = new SistemaElectrodomesticos();


        public void IniciarProtocoloCierre ()
        {
            iniciarProtocolo();
        }

        // Cuando decidamos pasar un metodo a traves de un metodo lo tendremos que hacer a traves de un delegado de tal forma que el delegado recoja lo que es el metodo

        public void Add(iniciarProtocoloDelegate metodoProtocolo) => iniciarProtocolo += metodoProtocolo;
        
        public void Remove(iniciarProtocoloDelegate metodoProtocolo) => iniciarProtocolo -= metodoProtocolo;

        
        
        
    }
}
