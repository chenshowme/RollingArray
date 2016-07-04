using System;

namespace RollingArray
{
    /// <summary>
    /// 一种环型数组，其长度N在创建后固定，当数组填充满时，继续添加的新元素会覆盖旧元素，
    /// 数组内始终存储最新添加的N个元素。
    /// </summary>
    /// <typeparam name="T">元素类型</typeparam>
    class RollingArray<T>
    {
        /// <summary>
        /// 泛型数组，用于存储各元素
        /// </summary>
        private T[] array;

        /// <summary>
        /// 下一个元素的写入位置
        /// </summary>
        private int nextPosition;
        /// <summary>
        /// 数组大小
        /// </summary>
        private int size;

        /// <summary>
        /// 数组中元素数量
        /// </summary>
        public int Count { get; private set; }

        /// <summary>
        /// 构造一个指定长度的泛型数组
        /// </summary>
        /// <param name="arraySize">数组大小</param>
        public RollingArray(int arraySize)
        {
            size = arraySize;
            array = new T[arraySize];
        }

        /// <summary>
        /// 往数组中添加元素，每写入一个元素，下一次写入位置后移一位，当超出边界时又从头开始覆盖写入。
        /// </summary>
        /// <param name="element">待添加元素</param>
        public void Add(T element)
        {
            array[nextPosition] = element;
            nextPosition = (nextPosition + 1) % size;

            if (Count < size)
                Count++;
        }

        /// <summary>
        /// 数组中是否存在元素
        /// </summary>
        public bool IsEmpty
        {
            get { return Count == 0; }
        }

        /// <summary>
        /// 循环数组的头，返回最早添加的元素
        /// </summary>
        public T Head
        {
            get
            {
                if (IsEmpty)
                    throw new IndexOutOfRangeException("当前数组为空！");
                if (Count < size)
                    return array[0];
                return array[nextPosition];
            }
        }

        /// <summary>
        /// 循环数组尾，返回最新添加的元素
        /// </summary>
        public T Tail
        {
            get
            {
                if (IsEmpty)
                    throw new IndexOutOfRangeException("当前数组为空！");
                if (nextPosition == 0)
                    return array[Count];
                return array[nextPosition - 1];
            }
        }
        /// <summary>
        /// 按照元素的插入顺序输出完整数组
        /// </summary>
        public T[] ToArray()
        {
            T[] temp = new T[Count];
            for (int i = 0; i < Count; i++)
            {
                if (Count < size)
                    temp[i] = array[i];
                else
                    temp[i] = array[(i + nextPosition) % size];
            }
            return temp;
        }

        /// <summary>
        /// 数组重置
        /// </summary>
        public void Clear()
        {
            nextPosition = 0;
            Count = 0;
        }

    }
}
