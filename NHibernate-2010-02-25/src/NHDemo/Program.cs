namespace NHDemo {
	using System;
	using FluentNHibernate.Cfg;
	using FluentNHibernate.Cfg.Db;
	using HibernatingRhinos.Profiler.Appender.NHibernate;
	using NHDemo.Model;
	using NHibernate;
	using NHibernate.ByteCode.Castle;
	using NHibernate.Cfg;
	using NHibernate.Linq;
	using System.Linq;

	public class Program {
		static void Main(string[] args) {
			//Initialise NHProf
			NHibernateProfiler.Initialize();

			//Configure NHibernate
			var config = new Configuration().Configure();

			var sessionFactory = config.BuildSessionFactory();

			//Begin a session & transaction
			using (ISession session = sessionFactory.OpenSession()) {
				using (var tx = session.BeginTransaction()) {
					//TODO: write a query that retrieves an individual customer (and its orders)


					tx.Commit();
				}
			}

			Console.ReadKey();
		}

		static Configuration BuildFluentConfiguration() {
			var cfg = Fluently.Configure()
				.Database(
					MsSqlConfiguration.MsSql2005.ConnectionString(c => c.FromConnectionStringWithKey("Demo"))
						.ProxyFactoryFactory(typeof (ProxyFactoryFactory))
				)
				.Mappings(m => m.FluentMappings.AddFromAssemblyOf<Customer>())
				.BuildConfiguration();

			return cfg;
		}
	}
}