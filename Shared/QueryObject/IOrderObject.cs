using System.Linq;

namespace BtcSolutions.Shared.QueryObject
{
    /// <summary>
    /// ��������� ������� ����������, ������ ����� ����������� IQueryable
    /// ��������� ��� ������� ��������� ���������� exprssion tree �.�. ef ��������� �� ��� ��� ��������� �����
    /// </summary>
    public interface IOrderObject<TEntity>
    {
        /// <summary>
        /// ����������� asc
        /// </summary>
        IQueryable<TEntity> Order(IQueryable<TEntity> query);

        /// <summary>
        /// ����������� �� desc
        /// </summary>
        IQueryable<TEntity> OrderDesc(IQueryable<TEntity> query);
    }
}