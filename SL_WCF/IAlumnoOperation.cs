using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SL_WCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IAlumnoOperation" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IAlumnoOperation
    {
        [OperationContract]
        SL_WCF.Result Add(ML.Alumnos alumnos);
        
        [OperationContract]
        SL_WCF.Result Update(ML.Alumnos alumnos);
        
        [OperationContract]
        SL_WCF.Result Delete(ML.Alumnos alumnos);
        
        [OperationContract]
        [ServiceKnownType(typeof(ML.Alumnos))]
        SL_WCF.Result GetAll();

        [OperationContract]
        [ServiceKnownType(typeof(ML.Alumnos))]
        SL_WCF.Result GetById(ML.Alumnos alumnos);
    }
}
