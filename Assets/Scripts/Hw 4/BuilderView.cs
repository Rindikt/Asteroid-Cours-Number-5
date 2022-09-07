using UnityEngine;

namespace Asteroid
{
    public class BuilderView : Builder
    {
        public BuilderView(GameObject gameObject) : base(gameObject)
        {

        }

        public BuilderView Name(string name)
        {
            _gameObject.name = name;
            return this;
        }

        public BuilderView Sprite(Sprite sprite)
        {
            var component = GetOrAddComponent<SpriteRenderer>();
            component.sprite = sprite;
            return this;
        }
    }
}
