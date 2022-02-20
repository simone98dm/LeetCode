namespace LeetCode.Solves.Base
{
    public interface IBaseSolution<T1>
    {
        void Solve(T1 param);
    }
    public interface IBaseSolution<T1, K>
    {
        K Solve(T1 param);
    }
    public interface IBaseSolution<T1, T2, K>
    {
        K Solve(T1 param1, T2 param2);
    }
    public interface IBaseSolution<T1, T2, T3, K>
    {
        K Solve(T1 param1, T2 param2, T3 param3);
    }
    public interface IBaseSolution<T1, T2, T3, T4, K>
    {
        K Solve(T1 param1, T2 param2, T3 param3, T4 param4);
    }
}