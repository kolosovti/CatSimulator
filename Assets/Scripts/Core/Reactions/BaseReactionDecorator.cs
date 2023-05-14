namespace CatSim.Core.Reactions
{
    public class BaseReactionDecorator : IReaction
    {
        protected IReaction WrappedReaction;

        public BaseReactionDecorator(IReaction wrappedReaction = null)
        {
            WrappedReaction = wrappedReaction;
        }

        public virtual void React()
        {
            WrappedReaction?.React();
        }
    }
}