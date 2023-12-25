using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkTo.Toolkit
{
    /// <summary>
    /// 转换扩展类
    /// </summary>
    public static class ConvertExtension
    {
        /// <summary>
        /// 把一个对象转换为String字符串
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string ToString2(this object obj)
        {
            if (obj == null)
                return string.Empty;
            return obj.ToString();
        }

        /// <summary>
        /// 将日期字符串转换为日期
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static DateTime? ToDateTime(this string str)
        {
            if (string.IsNullOrEmpty(str)) return null;
            if (DateTime.TryParse(str, out DateTime dateTime))
            {
                return dateTime;
            }
            return null;
        }

        /// <summary>
        /// 检查string是否为"true","1"如果是返回True，否则返回False(null, "false", "0", etc.)
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool ToBoolean(this string str)
        {
            if (string.IsNullOrEmpty(str)) return false;
            return str.ToLower() == bool.TrueString.ToLower();
        }

        /// <summary>
        /// 检查字符串是否为null或空字符串
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsNullOrEmpty(this string str)
        {
            return string.IsNullOrEmpty(str);
        }

        /// <summary>
        /// 字符串转换为32位int整数
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static int ToInt(this string str)
        {
            if (int.TryParse(str, out int intValue))
            {
                return intValue;
            }
            return 0;
        }

        /// <summary>
        /// 字符串转换为64位long整数
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static long ToLong(this string str)
        {
            if (long.TryParse(str, out long longValue))
            {
                return longValue;
            }
            return 0;
        }

        /// <summary>
        /// 字符串转换为decimal
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static decimal ToDecimal(this string str)
        {
            if (decimal.TryParse(str, out decimal decimalValue))
            {
                return decimalValue;
            }
            return 0;
        }

        /// <summary>
        /// 字符串转换为double
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static double ToDouble(this string str)
        {
            if (double.TryParse(str, out double doubleValue))
            {
                return doubleValue;
            }
            return 0;
        }

        /// <summary>
        /// 字符串转换为float
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static float ToFloat(this string str)
        {
            if (float.TryParse(str, out float floatValue))
            {
                return floatValue;
            }
            return 0;
        }

        /// <summary>
        /// DataRow转换为实体类
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="datarow"></param>
        /// <returns></returns>
        public static T ConvertToEntityByDataRow<T>(this DataRow dataRow) where T : new()
        {
            Type type = typeof(T);
            PropertyInfo[] properties = type.GetProperties();
            T t = new T();
            if (dataRow == null) return t;
            foreach (PropertyInfo property in properties)
            {
                foreach (DataColumn column in dataRow.Table.Columns)
                {
                    if (property.Name.Equals(column.ColumnName, StringComparison.OrdinalIgnoreCase))
                    {
                        object value = dataRow[column];
                        if (value != null && value != DBNull.Value)
                        {
                            if (value.GetType().Name != property.PropertyType.Name)
                            {

                                if (property.PropertyType.IsEnum)
                                {
                                    property.SetValue(t, Enum.Parse(property.PropertyType, value.ToString()), null);
                                }
                                else
                                {
                                    try
                                    {
                                        value = Convert.ChangeType(value, (Nullable.GetUnderlyingType(property.PropertyType) ?? property.PropertyType));
                                        property.SetValue(t, value, null);
                                    }
                                    catch { }
                                }
                            }
                            else
                            {
                                property.SetValue(t, value, null);
                            }
                        }
                        else
                        {
                            property.SetValue(t, null, null);
                        }
                        break;
                    }
                }
            }
            return t;
        }

        /// <summary>
        /// 通用简单实体类型转换
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sourceEntity"></param>
        /// <returns></returns>
        public static T ConvertToEntity<T>(this object sourceEntity) where T : new()
        {
            T t = new T();
            Type sourceType = sourceEntity.GetType();
            if (sourceType.Equals(typeof(DataRow)))
            {
                // DataRow 类型
                DataRow dataRow = sourceEntity as DataRow;
                t = dataRow.ConvertToEntityByDataRow<T>();
            }
            else
            {
                Type type = typeof(T);
                PropertyInfo[] properties = type.GetProperties();
                PropertyInfo[] sourceProperties = sourceType.GetProperties();
                foreach (PropertyInfo property in properties)
                {
                    foreach (var sourceProperty in sourceProperties)
                    {
                        if (sourceProperty.Name.Equals(property.Name, StringComparison.OrdinalIgnoreCase))
                        {
                            object value = sourceProperty.GetValue(sourceEntity, null);
                            if (value != null && value != DBNull.Value)
                            {
                                if (sourceProperty.PropertyType.Name != property.PropertyType.Name)
                                {
                                    if (property.PropertyType.IsEnum)
                                    {
                                        property.SetValue(t, Enum.Parse(property.PropertyType, value.ToString()), null);
                                    }
                                    else
                                    {
                                        try
                                        {
                                            value = Convert.ChangeType(value, (Nullable.GetUnderlyingType(property.PropertyType) ?? property.PropertyType));
                                            property.SetValue(t, value, null);
                                        }
                                        catch { }
                                    }
                                }
                                else
                                {
                                    property.SetValue(t, value, null);
                                }
                            }
                            else
                            {
                                property.SetValue(t, null, null);
                            }
                            break;
                        }
                    }
                }
            }
            return t;
        }


        /// <summary>
        /// 通用简单实体类转换
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <returns></returns>
        public static List<T> ConvertToEntityList<T>(this object list) where T : new()
        {
            List<T> t = new List<T>();
            if (list == null) return t;
            Type sourceObj = list.GetType();
            if (sourceObj.Equals(typeof(DataTable)))
            {
                var dataTable = list as DataTable;
                t = dataTable.Rows.Cast<DataRow>().Where(m => !(m.RowState == DataRowState.Deleted || m.RowState == DataRowState.Detached)).Select(m => m.ConvertToEntityByDataRow<T>()).ToList();
            }
            else if (list is IEnumerable)
            {
                t = ((IList)list).Cast<object>().Select(m => m.ConvertToEntity<T>()).ToList();
            }
            return t;
        }

        /// <summary>
        /// 转换为DataTable，如果是集合没有数据行的时候会抛异常。
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static DataTable ConvertToDataTable(this object list)
        {
            if (list == null) return null;
            DataTable dataTable = new DataTable();
            if (list is IEnumerable)
            {
                var li = (IList)list;
                //li[0]代表的是一个对象，list没有行时，会抛异常。
                PropertyInfo[] properties = li[0].GetType().GetProperties();
                dataTable.Columns.AddRange(properties.Where(m => !m.PropertyType.IsClass || !m.PropertyType.IsInterface).Select(m =>
                    new DataColumn(m.Name, Nullable.GetUnderlyingType(m.PropertyType) ?? m.PropertyType)).ToArray());
                foreach (var item in li)
                {
                    DataRow dataRow = dataTable.NewRow();
                    foreach (PropertyInfo property in properties.Where(m => m.PropertyType.GetProperty("Item") == null))    //过滤含有索引器的属性
                    {
                        object value = property.GetValue(item, null);
                        dataRow[property.Name] = value ?? DBNull.Value;
                    }
                    dataTable.Rows.Add(dataRow);
                }
            }
            else
            {
                PropertyInfo[] properties = list.GetType().GetProperties();
                properties = properties.Where(m => m.PropertyType.GetProperty("Item") == null).ToArray();   //过滤含有索引器的属性
                dataTable.Columns.AddRange(properties.Select(m => new DataColumn(m.Name, Nullable.GetUnderlyingType(m.PropertyType) ?? m.PropertyType)).ToArray());
                DataRow dataRow = dataTable.NewRow();
                foreach (PropertyInfo property in properties)
                {
                    object value = property.GetValue(list, null);
                    dataRow[property.Name] = value ?? DBNull.Value;
                }
                dataTable.Rows.Add(dataRow);
            }
            return dataTable;
        }

        /// <summary>
        /// 实体类公共属性值复制
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="target"></param>
        public static void CopyTo(this object entity, object target)
        {
            if (target == null) return;
            if (entity.GetType() != target.GetType())
                return;
            PropertyInfo[] properties = target.GetType().GetProperties();
            foreach (PropertyInfo property in properties)
            {
                if (property.PropertyType.GetProperty("Item") != null)
                    continue;
                object value = property.GetValue(entity, null);
                if (value != null)
                {
                    if (value is ICloneable)
                    {
                        property.SetValue(target, (value as ICloneable).Clone(), null);
                    }
                    else
                    {
                        property.SetValue(target, value.Copy(), null);
                    }
                }
                else
                {
                    property.SetValue(target, null, null);
                }
            }
        }

        public static object Copy(this object obj)
        {
            if (obj == null) return null;
            object targetDeepCopyObj;
            Type targetType = obj.GetType();
            if (targetType.IsValueType == true)
            {
                targetDeepCopyObj = obj;
            }
            else
            {
                targetDeepCopyObj = Activator.CreateInstance(targetType);   //创建引用对象
                MemberInfo[] memberCollection = obj.GetType().GetMembers();

                foreach (MemberInfo member in memberCollection)
                {
                    if (member.GetType().GetProperty("Item") != null)
                        continue;
                    if (member.MemberType == MemberTypes.Field)
                    {
                        FieldInfo field = (FieldInfo)member;
                        object fieldValue = field.GetValue(obj);
                        if (fieldValue is ICloneable)
                        {
                            field.SetValue(targetDeepCopyObj, (fieldValue as ICloneable).Clone());
                        }
                        else
                        {
                            field.SetValue(targetDeepCopyObj, fieldValue.Copy());
                        }
                    }
                    else if (member.MemberType == MemberTypes.Property)
                    {
                        PropertyInfo property = (PropertyInfo)member;
                        MethodInfo method = property.GetSetMethod(false);
                        if (method != null)
                        {
                            object propertyValue = property.GetValue(obj, null);
                            if (propertyValue is ICloneable)
                            {
                                property.SetValue(targetDeepCopyObj, (propertyValue as ICloneable).Clone(), null);
                            }
                            else
                            {
                                property.SetValue(targetDeepCopyObj, propertyValue.Copy(), null);
                            }
                        }
                    }
                }
            }
            return targetDeepCopyObj;
        }

    }
}
