namespace Iterator
{
    public class AlphabeticalOrderIterator : Iterator
    {
        private WordsCollection _collection;
        private int _position = -1;
        private bool _reverse = false;

        public AlphabeticalOrderIterator(WordsCollection collection, bool reverse)
        {
            _collection = collection;
            _reverse = reverse;

            if (reverse)
            {
                _position = collection.GetItems().Count();
            }
        }
        public override object Current()
        {
            return _collection.GetItems()[_position];
        }

        public override int Key()
        {
            return _position;
        }

        public override bool MoveNext()
        {
            int updatePosistion = _position + (_reverse ? -1 : 1);

            if (updatePosistion >= 0 && updatePosistion < _collection.GetItems().Count)
            {
                _position = updatePosistion;
                return true;
            }

            return false;
        }

        public override void Reset()
        {
            _position = _reverse ? _collection.GetItems().Count - 1: 0;
        }
    }
}