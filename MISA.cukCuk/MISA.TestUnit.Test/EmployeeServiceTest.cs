using NUnit.Framework;
using NSubstitute;
using MISA.Service.Service;
using MISA.Data.Interfaces;
using MISA.Model;
using System.Collections.Generic;

namespace MISA.TestUnit.Test
{
    [TestFixture]
    public class EmployeeServiceTest
    {
        public void Setup()
        {
        }
        #region USE NSubstitute 
        /// <summary>
        /// kiểm tra employeeCode is empty
        /// </summary>
        [Test]
        public void NSubstituteShouldReturnTrueEveryValidateEmployeeNull()
        {
            var employeeCode = string.Empty;
            IEmployeeRepository employeeRepository = Substitute.For<IEmployeeRepository>();
            var _employeeService = new EmployeeService(employeeRepository);
            Assert.IsFalse(_employeeService.checkDuplicate(employeeCode));
        }

        /// <summary>
        /// nếu page=0 và size=0 thì lấy tất cả data
        /// </summary>
        [Test] 
        public void ShouldGetAllDataIfPageAndSizeOsZero()
        {
            IEmployeeRepository employeeRepository = Substitute.For<IEmployeeRepository>();
            var employeeService = new EmployeeService(employeeRepository);
            Assert.IsNotNull(employeeService.Get(0, 0));
        }
        
        /// <summary>
        /// nếu param is null when delete ->false(xóa thất bại)
        /// </summary>
        [Test]
        public void ShouldReturnFalseIfValueOfDeleteIsNUll()
        {
            IEmployeeRepository employeeRepository = Substitute.For<IEmployeeRepository>();
            var employeeService = new EmployeeService(employeeRepository);
            Assert.IsFalse(employeeService.Delete(null));
        }


        #endregion

        #region fake stubs
        /// <summary>
        /// if empployeeCode is empty-> true(chưa tồn tại mã nhân viên)
        /// </summary>
        [Test]
        public void ShouldReturnTrueEveryCheckDuplicateEmployeeNull()
        {
            var employeeCode = string.Empty;
            var check = new SubEmpoyee();
            var employeeService = new EmployeeService(check);
            Assert.IsTrue(employeeService.checkDuplicate(employeeCode));
        }


        //case stubs
        public class SubEmpoyee : IEmployeeRepository
        {
            public Employee checkItem(object value)
            {
                return null;
            }

            public bool Delete(Employee value)
            {
                throw new System.NotImplementedException();
            }

            public IEnumerable<Employee> Get(int page, int size)
            {
                throw new System.NotImplementedException();
            }

            public IEnumerable<Employee> GetAllData()
            {
                throw new System.NotImplementedException();
            }

            public Employee GetByID(object Id)
            {
                throw new System.NotImplementedException();
            }

            public int GetCountData()
            {
                throw new System.NotImplementedException();
            }

            public string GetMaxItemCode()
            {
                throw new System.NotImplementedException();
            }

            public int Insert(Employee value)
            {
                throw new System.NotImplementedException();
            }

            public bool Update(Employee value)
            {
                throw new System.NotImplementedException();
            }
        }
        #endregion
    }
}