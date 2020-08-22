using System;
using Xunit;
using Graphs;
using System.Linq;

namespace XUnitTest_Graph
{
    public class UnitTest1
    {
        [Fact]
        public void AddVertexToGraph()
        {
            // Arrange
            Graph<string, int> graph = new Graph<string, int>();

            // Act
            graph.AddVertex("Washington");

            // Assert
            Assert.NotNull(graph);
        }

        [Fact]

        public void AddDirectedEdge()
        {
            // Arrange

            Graph<string, int> graph = new Graph<string, int>();

            // Act
            var a = graph.AddVertex("Washington");
            var b = graph.AddVertex("Washington");

            graph.AddDirectedEdge(a, b, 100);

            var data = graph.AdjacencyList[a].Count;

            var destination = graph.AdjacencyList[a].FirstOrDefault(x => x.Vertex == b);

            Assert.Equal(1, data);
            Assert.Equal(100, destination.Weight);
            Assert.NotNull(destination);
            Assert.NotNull(destination.Vertex);
        }

        [Fact]
        public void AddUndirectedEdge()
        {
            // Arrange

            Graph<string, int> graph = new Graph<string, int>();

            // Act
            var a = graph.AddVertex("Washington");
            var b = graph.AddVertex("California");

            graph.AddDirectedEdge(a, b, 50);

            var countA = graph.AdjacencyList[a].Count;
            var countB = graph.AdjacencyList[b].Count;

            var destinationA = graph.AdjacencyList[a].FirstOrDefault(x => x.Vertex == b);
            var destinationB = graph.AdjacencyList[b].FirstOrDefault(x => x.Vertex == a);

            Assert.Equal(1, countA);
            Assert.Equal(1, countB);
            Assert.Equal(50, destinationA.Weight);
            Assert.Equal(50, destinationB.Weight);

        }

        //[Fact]
        //public void GetNeighbors()
        //{
        //    // Arrange

        //    Graph<string, int> graph = new Graph<string, int>();

        //    // Act
        //    var a = graph.AddVertex("Washington");
        //    var b = graph.AddVertex("California");
        //    var b = graph.AddVertex("Texas");
            
        //    graph.AddDirectedEdge(a, b, 50);


        //    var countA = graph.AdjacencyList[a].Count;
        //}

        

    }

}
