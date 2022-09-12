using MVC_8.Models.Home;

namespace MVC_8.Models.ViewModels {
    public class PageViewModel {
        public EntityConst Entity { get; }
        public PageViewModel(EntityConst entity) {
            Entity = entity;
        }
    }
}
