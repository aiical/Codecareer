using System;
using System.Collections.Generic;
using System.Data;

namespace P15_3
{
    public class Province
    {
        int id;
        public int Id
        {
            get { return id; }
        }

        string name;
        public string Name
        {
            get { return name; }
        }

        public string Introduction { get; set; }

        public Province(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public override string ToString()
        {
            return name;
        }

        public static List<Province> LoadAll(IDbConnection conn)
        {
            List<Province> provinces = new List<Province>();
            IDbCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT id, name, introduction FROM Province ORDER BY id";
            IDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
                provinces.Add(new Province((short)reader[0], reader[1].ToString()) { Introduction = reader[2].ToString() });
            reader.Close();
            return provinces;
        }
    }

    public class City
    {
        int id;
        public int Id
        {
            get { return id; }
        }

        string name;
        public string Name
        {
            get { return name; }
        }

        public string Introduction { get; set; }
        public Province Province { get; set; }

        public City(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public override string ToString()
        {
            return name;
        }

        public static List<City> LoadAll(IDbConnection conn, List<Province> provinces)
        {
            List<City> cities = new List<City>();
            IDbCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT id, name, introduction, provinceId FROM City ORDER BY id";
            IDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
                cities.Add(new City((int)reader[0], reader[1].ToString()) { Introduction = reader[2].ToString(), Province = provinces[(short)reader[3] - 1] });
            reader.Close();
            return cities;
        }
    }

    public class Scene
    {
        int id;
        public int Id
        {
            get { return id; }
        }

        string name;
        public string Name
        {
            get { return name; }
        }

        public string Introduction { get; set; }
        public SceneType Type { get; set; }
        public byte Star { get; set; }
        public decimal Price { get; set; }
        public City City { get; set; }

        public Scene(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public override string ToString()
        {
            return name;
        }

        public static List<Scene> LoadAll(IDbConnection conn, List<City> cities)
        {
            List<Scene> scenes = new List<Scene>();
            IDbCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT id, name, introduction, type, star, price, cityId FROM Scene ORDER BY id";
            IDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
                scenes.Add(new Scene((int)reader[0], reader[1].ToString()) { Introduction = reader[2].ToString(), Type = (SceneType)((byte)reader[3]), Star = reader[4] != DBNull.Value ? (byte)reader[4] : (byte)0, Price = (decimal)reader[5], City = cities[(int)reader[6] - 1] });
            reader.Close();
            return scenes;
        }
    }

    public enum SceneType
    {
        自然山水, 海滨沙滩, 草原, 沙漠, 公园, 游乐园, 博物馆, 纪念馆, 名胜古迹, 人文建筑, 表演, 休闲购物, Undefined
    }
}