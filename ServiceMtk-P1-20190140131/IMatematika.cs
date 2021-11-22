using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceMtk_P1_20190140131
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IMatematika
    {
        [OperationContract]
        /* output->*/
        [FaultContract(typeof(MathFault))] //Membuat kelas yang melambangkan exception
        int Tambah(int a, int b); //method

        [OperationContract]
        [FaultContract(typeof(MathFault))] //Membuat kelas yang melambangkan exception
        int Kurang(int a, int b); //input


        [OperationContract]
        [FaultContract(typeof(MathFault))] //Membuat kelas yang melambangkan exception
        int Kali(int a, int b);


        [OperationContract]
        [FaultContract(typeof(MathFault))] //Membuat kelas yang melambangkan exception
        int Bagi(int a, int b);


        [OperationContract]
        [FaultContract(typeof(MathFault))] //Membuat kelas yang melambangkan exception
        Koordinat TKoordinat(Koordinat a, Koordinat b); //object dari class

    }

    [DataContract]
    //Tambahkan class berikut
    class MathFault
    {
        [DataMember]
        public string Kode { get; set; }
        [DataMember]
        public string Pesan { get; set; }
    }
    public class Koordinat
    {
        private int _x, _y; //atribut
        [DataMember]//membuka koordinat, x,y
        public int X //properties
        {
            get { return _x; }
            set { _x = value; }
        }
        [DataMember]
        public int Y //properties
        {
            get { return _y; }
            set { _y = value; }
        }
    }

}
