using MDD4All.SpecIF.DataModels;
using MDD4All.SpecIF.DataProvider.Contracts;
using MDD4All.UI.DataModels.Tree;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MDD4All.SpecIF.ViewModels.Testing
{
    public class TestSuiteSelectionTreeViewModel : ITree
    {

        public TestSuiteSelectionTreeViewModel(ISpecIfDataProviderFactory specIfDataProviderFactory,
                                               Key key) 
        {
            _specIfDataProviderFactory = specIfDataProviderFactory;
            _metadataReader = _specIfDataProviderFactory.MetadataReader;
            _specIfDataWriter = _specIfDataProviderFactory.DataWriter;
            _specIfDataReader = _specIfDataProviderFactory.DataReader;

            Node hierarchyRoot = _specIfDataReader.GetHierarchyByKey(key);
           
            RootNode = InitializeTestSuteSelectionTree(hierarchyRoot);

            _treeRootNodes = new ObservableCollection<ITreeNode>();
            _treeRootNodes.Add(RootNode);

            SelectedNode = RootNode;
        }

        private TestResourceNodeViewModel InitializeTestSuteSelectionTree(Node hierarchyRootNode)
        {
            TestResourceNodeViewModel result = null;
            
            // hier den Baum aufbauen!!


            return result;
        }

        private ISpecIfDataProviderFactory _specIfDataProviderFactory;

        private ISpecIfMetadataReader _metadataReader;

        public ISpecIfMetadataReader MetadataReader
        {
            get { return _metadataReader; }

        }

        private ISpecIfDataReader _specIfDataReader;

        public ISpecIfDataReader DataReader
        {
            get
            {
                return _specIfDataReader;
            }
        }

        private ISpecIfDataWriter _specIfDataWriter;

        public ISpecIfDataWriter DataWriter
        {
            get
            {
                return _specIfDataWriter;
            }
        }

        public TestResourceNodeViewModel RootNode { get; set; }

        private ObservableCollection<ITreeNode> _treeRootNodes = new ObservableCollection<ITreeNode>();


        public ObservableCollection<ITreeNode> TreeRootNodes
        {
            get
            {
                return _treeRootNodes;
            }
        }

        public ITreeNode SelectedNode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
