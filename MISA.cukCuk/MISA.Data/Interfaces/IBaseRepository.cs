using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.Data.Interfaces
{
    public interface IBaseRepository<T>
    {

        /// <summary>
        /// lấy data theo phân trang
        /// </summary>
        /// <returns>list T</returns> 
        /// CreatedBy: DVQuan(14/10/2020)
        IEnumerable<T> Get(int page, int size);

        /// <summary>
        /// lấy all data 
        /// </summary>
        /// <returns>list T</returns> 
        /// CreatedBy: DVQuan(14/10/2020)
        IEnumerable<T> GetAllData();


        /// <summary>
        /// lấy data theo ID
        /// </summary>
        /// <param name="Id">id của đối tượng</param> 
        /// <returns>list<T></returns> 
        ///  CreatedBy: DVQuan(14/10/2020)
        T GetByID(Object Id);


        /// <summary>
        /// thêm mới
        /// </summary>
        /// <param name="value"> t value</param>
        /// <returns>số bản ghi đã thay đổi</returns> 
        /// CreatedBy: DVQuan(14/10/2020)
        int Insert(T value);


        /// <summary>
        /// sửa 
        /// </summary>
        /// <param name="value"></param> T value
        /// <returns> true(update thành công) or false(update thất bại)</returns>
        ///  CreatedBy: DVQuan(14/10/2020)
        bool Update(T value);


        /// <summary>
        /// xóa
        /// </summary>
        /// <param name="value">T value</param> 
        /// <returns>true(xóa thành công) or flase(xóa thất cại)</returns> 
        ///  CreatedBy: DVQuan(14/10/2020)
        bool Delete(T value);


        /// <summary>
        /// lấy số lượng danh sách các bản ghi
        /// </summary>
        /// <returns>tổng số bản ghi</returns> 
        /// CreatedBy: DVQuan
        int GetCountData();

        /// <summary>
        /// lấy Code của item lớn nhất
        /// </summary>
        /// <returns>Item code</returns> 
        String GetMaxItemCode();
    }

}
