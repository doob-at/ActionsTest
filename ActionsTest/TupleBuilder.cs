using System;

namespace ActionsTest
{
    public class TupleBuilder
    {
        public (T1, T2) Build<T1, T2>(T1 value1, T2 value2)
        {
            return (value1, value2);
        }

        public (T1, T2, T3) Build<T1, T2, T3>(T1 value1, T2 value2, T3 value3)
        {
            return (value1, value2, value3);
        }
    }
}
