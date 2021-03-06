// CodeContracts
// 
// Copyright (c) Microsoft Corporation
// 
// All rights reserved. 
// 
// MIT License
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED *AS IS*, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

// File System.ComponentModel.Composition.Hosting.CompositionContainer.cs
// Automatically generated contract file.
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Diagnostics.Contracts;
using System;

// Disable the "this variable is not used" warning as every field would imply it.
#pragma warning disable 0414
// Disable the "this variable is never assigned to".
#pragma warning disable 0067
// Disable the "this event is never assigned to".
#pragma warning disable 0649
// Disable the "this variable is never used".
#pragma warning disable 0169
// Disable the "new keyword not required" warning.
#pragma warning disable 0109
// Disable the "extern without DllImport" warning.
#pragma warning disable 0626
// Disable the "could hide other member" warning, can happen on certain properties.
#pragma warning disable 0108


namespace System.ComponentModel.Composition.Hosting
{
  public partial class CompositionContainer : ExportProvider, System.ComponentModel.Composition.ICompositionService, IDisposable
  {
    #region Methods and constructors
    public void Compose(CompositionBatch batch)
    {
      Contract.Requires(batch != null);
    }

    public CompositionContainer()
    {
    }

    public CompositionContainer(System.ComponentModel.Composition.Primitives.ComposablePartCatalog catalog, bool isThreadSafe, ExportProvider[] providers)
    {
    }

    public CompositionContainer(ExportProvider[] providers)
    {
    }

    public CompositionContainer(System.ComponentModel.Composition.Primitives.ComposablePartCatalog catalog, ExportProvider[] providers)
    {
    }

    public void Dispose()
    {
    }

    protected virtual new void Dispose(bool disposing)
    {
    }

    protected override IEnumerable<System.ComponentModel.Composition.Primitives.Export> GetExportsCore(System.ComponentModel.Composition.Primitives.ImportDefinition definition, AtomicComposition atomicComposition)
    {
      return default(IEnumerable<System.ComponentModel.Composition.Primitives.Export>);
    }

    public void ReleaseExport<T>(Lazy<T> export)
    {
    }

    public void ReleaseExport(System.ComponentModel.Composition.Primitives.Export export)
    {
    }

    public void ReleaseExports(IEnumerable<System.ComponentModel.Composition.Primitives.Export> exports)
    {
      Contract.Requires(exports != null);
    }

    public void ReleaseExports<T>(IEnumerable<Lazy<T>> exports)
    {
      Contract.Requires(exports != null);
    }

    public void ReleaseExports<T, TMetadataView>(IEnumerable<Lazy<T, TMetadataView>> exports)
    {
      Contract.Requires(exports != null);
    }

    public void SatisfyImportsOnce(System.ComponentModel.Composition.Primitives.ComposablePart part)
    {
    }
    #endregion

    #region Properties and indexers
    public System.ComponentModel.Composition.Primitives.ComposablePartCatalog Catalog
    {
      get
      {
        return default(System.ComponentModel.Composition.Primitives.ComposablePartCatalog);
      }
    }

    public System.Collections.ObjectModel.ReadOnlyCollection<ExportProvider> Providers
    {
      get
      {
        return default(System.Collections.ObjectModel.ReadOnlyCollection<ExportProvider>);
      }
    }
    #endregion
  }
}
