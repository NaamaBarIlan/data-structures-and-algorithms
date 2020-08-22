using System;
using System.Collections.Generic;
using System.Threading;

namespace Graphs
{
    public class Graph<T,W>
    {
        // Adjacency List
        // Key is the vertex
        // ValueTuple is ThreadExceptionEventArgs list of edges with a specific
        // data type as weigh and connected to a specific vertex
        public Dictionary<Vertex<T>, List<Edge<T,W>>> AdjacencyList { get; set; }
        private int _size = 0;
        public Graph()
        {
            // we have to allocate memory on the heap for the collection.
            // Null reference exception if we do not do this because "nothing will exist"
            AdjacencyList = new Dictionary<Vertex<T>, List<Edge<T, W>>>();
        }

        // Add Vertex/node
        public Vertex<T> AddVertex(T value)
        {
            Vertex<T> vertex = new Vertex<T>(value);
            AdjacencyList.Add(vertex, new List<Edge<T, W>>());
            _size++;
            return vertex;

        }

        // add Edge
        public void AddDirectedEdge(Vertex<T> a, Vertex<T> b, W weight)
        {
            // add this edge to vertex B
            // a is our source
            // b is our destination
            // weight is the value of the edge
            Edge<T, W> edge = new Edge<T, W>
            {
                Vertex = b,
                Weight = weight
            };

            AdjacencyList[a].Add(edge);
        }

        public void AddUndirectedEdge(Vertex<T> a, Vertex<T> b, W weight)
        {
            AddDirectedEdge(a, b, weight);
            AddDirectedEdge(b, a, weight);
        }

        public List<Edge<T,W>> GetNeighbors(Vertex<T> vertex)
        {
            return AdjacencyList[vertex];
        }

        public Vertex<T> GetVertex(T value)
        {
            // traverse over our adjacenty list
            // see if the value that we are checking for exists in a single vertex
            // do any of the verticies have this value?
            // we are assuming no duplicates
            // if this was duplicates, make the return type a list<vertex<T>> and then 
            // add the 

            foreach (var vertex in AdjacencyList)
            {
                if (vertex.Key.Value.Equals(value))
                {
                    return vertex.Key;
                }
            }

            return null;
        }

        public List<Vertex<T>> GetAllVertices()
        {
            List<Vertex<T>> vertices = new List<Vertex<T>>();
            foreach (var vertex in AdjacencyList)
            {
                vertices.Add(vertex.Key);
            }

            return vertices;
        }

        public int Size()
        {
            return _size;
        }

        public void Print()
        {
            foreach (var item in AdjacencyList)
            {
                Console.WriteLine($"Vertex {item.Key.Value} ->");

                foreach (var edge in item.Value)
                {
                    Console.WriteLine($"{edge.Vertex.Value}, {edge.Weight} ->");
                }

                Console.WriteLine("null");
            }
        }
    }
}
