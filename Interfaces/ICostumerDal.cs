using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface ICostumerDal
    {
        void Add();
        void Uptade();
        void Delete();

    }
    class SqlServiceCustomerDal : ICustomerDal
    {

    }
    class OracleCustomerDal : ICustomerDal
    {

    }
