using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace Contracts
{
   [ServiceContract(Name="CalculatorService", Namespace="http://www.artech.com/")]
       public interface ICalculator
       {
        [OperationContract]
        Calculator AddExy(Calculator x, Calculator y);

        [OperationContract]
        Calculator Subtract(Calculator x, Calculator y);

        [OperationContract]
        Calculator Multiply(Calculator x, Calculator y);

        [OperationContract]
        Calculator Divide(Calculator x, Calculator y);    
    } 
}
