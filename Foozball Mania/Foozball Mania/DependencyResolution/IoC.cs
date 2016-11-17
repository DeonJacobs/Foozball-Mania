using Foozball_Mania.Models.DataSource;
using StructureMap;
namespace Foozball_Mania {
    public static class IoC {
        public static IContainer Initialize() {
            ObjectFactory.Initialize(x =>
                        {
                            x.Scan(scan =>
                                    {
                                        scan.TheCallingAssembly();
                                        scan.WithDefaultConventions();
                                    });
                            x.For<IMatchDataSource>().Use<MatchDb>();
                        });
            return ObjectFactory.Container;
        }
    }
}