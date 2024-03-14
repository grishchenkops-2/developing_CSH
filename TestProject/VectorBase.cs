namespace ConsoleApp1
{
    abstract class VectorBase 
    {
        protected abstract void input_user();
        protected abstract void input_random();
        public virtual void input(bool flag = false)
        {
            if (flag)
            {
                input_user();
            }
            else
            {
                input_random();
            }
        }
        public abstract void print();
        public abstract void average();
    }
    
}