using System.ComponentModel;

namespace Codify.Automation.Core.Extensions
{
    public static class ContainerExtensions
    {
        public static PageObjects.Container GetContainerByTitle(this PageObjects.Container container, string title)
        {
            PageObjects.Container neededContainer;
            try
            {
                neededContainer = container.GetComponent<PageObjects.Container>(title);
                return neededContainer ?? null!;
            }
            catch (Exception)
            {
                List<PageObjects.Container> containerList = new List<PageObjects.Container>();
                container.GetType().GetProperties().Where(p => p.PropertyType.BaseType == typeof(Container)).ToList()
                    .ForEach(x => containerList.Add(x.GetValue(container) as PageObjects.Container));
                foreach (var cont in containerList)
                {
                    neededContainer = cont.GetContainerByTitle(title);
                    if (neededContainer != null) return neededContainer;
                }
                return null!;
            }
        }
    }
}
