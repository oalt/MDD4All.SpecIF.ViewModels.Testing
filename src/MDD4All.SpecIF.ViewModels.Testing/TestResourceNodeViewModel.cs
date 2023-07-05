using MDD4All.SpecIF.DataModels;
using MDD4All.SpecIF.DataProvider.Contracts;
using MDD4All.UI.DataModels.Tree;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MDD4All.SpecIF.ViewModels.Testing
{
    public class TestResourceNodeViewModel : ITreeNode
    {

        public TestResourceNodeViewModel(ISpecIfMetadataReader metadataReader,
                                         ISpecIfDataReader dataReader,
                                         ITree tree,
                                         Node node)
        {
            _metadataReader = metadataReader;
            _specIfDataReader = dataReader;
            Tree = tree;
            _node = node;
        }

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

        private Node _node;

        public ITree Tree { get; }

        public ObservableCollection<ITreeNode> Children => throw new NotImplementedException();

        public ITreeNode Parent { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int Index => throw new NotImplementedException();

        public bool HasChildNodes => throw new NotImplementedException();

        public bool IsExpanded { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsSelected { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool IsLoading => throw new NotImplementedException();

        public bool IsDisabled { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public event EventHandler TreeStateChanged;
    }
}
