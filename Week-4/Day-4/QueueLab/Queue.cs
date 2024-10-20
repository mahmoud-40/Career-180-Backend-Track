namespace QueueLab
{
    class Queue<t>
    {
        t[] _arr;
        private int front, back;

        public Queue(int size = 10)
        {
            _arr = new t[size];
            front = back = 0;
        }

        public void InQueue(t item)
        {
            if (back == _arr.Length)
            {
                t[] temp = new t[_arr.Length * 2];
                for (int i = 0; i < _arr.Length; i++)
                {
                    temp[i] = _arr[i];
                }
                _arr = temp;
            }
            _arr[back++] = item;
        }
        public t DeQueue() 
        {
            if (front == back)
            {
                throw new Exception("Queue is empty");
            }
            return _arr[front++];
            
        }
    }
}