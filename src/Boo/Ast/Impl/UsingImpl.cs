#region license
// boo - an extensible programming language for the CLI
// Copyright (C) 2004 Rodrigo B. de Oliveira
//
// This program is free software; you can redistribute it and/or
// modify it under the terms of the GNU General Public License
// as published by the Free Software Foundation; either version 2
// of the License, or (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.
//
// As a special exception, if you link this library with other files to
// produce an executable, this library does not by itself cause the
// resulting executable to be covered by the GNU General Public License.
// This exception does not however invalidate any other reasons why the
// executable file might be covered by the GNU General Public License.
//
// Contact Information
//
// mailto:rbo@acm.org
#endregion

//
// DO NOT EDIT THIS FILE!
//
// This file was generated automatically by the
// ast.py script on Sat Jan 17 16:10:34 2004
//
using System;

namespace Boo.Ast.Impl
{
	[Serializable]
	public abstract class UsingImpl : Node
	{
		protected string _namespace;
		protected ReferenceExpression _assemblyReference;
		protected ReferenceExpression _alias;
		
		protected UsingImpl()
		{
 		}
		
		protected UsingImpl(string namespace_, ReferenceExpression assemblyReference, ReferenceExpression alias)
		{
 			Namespace = namespace_;
			AssemblyReference = assemblyReference;
			Alias = alias;
		}
		
		protected UsingImpl(LexicalInfo lexicalInfo, string namespace_, ReferenceExpression assemblyReference, ReferenceExpression alias) : base(lexicalInfo)
		{
 			Namespace = namespace_;				
			AssemblyReference = assemblyReference;				
			Alias = alias;				
		}
		
		protected UsingImpl(LexicalInfo lexicalInfo) : base(lexicalInfo)
		{
 		}
		
		public override NodeType NodeType
		{
			get
			{
				return NodeType.Using;
			}
		}
		public string Namespace
		{
			get
			{
				return _namespace;
			}
			
			set
			{
				
				_namespace = value;
			}
		}
		public ReferenceExpression AssemblyReference
		{
			get
			{
				return _assemblyReference;
			}
			
			set
			{
				
				if (_assemblyReference != value)
				{
					_assemblyReference = value;
					if (null != _assemblyReference)
					{
						_assemblyReference.InitializeParent(this);
					}
				}
			}
		}
		public ReferenceExpression Alias
		{
			get
			{
				return _alias;
			}
			
			set
			{
				
				if (_alias != value)
				{
					_alias = value;
					if (null != _alias)
					{
						_alias.InitializeParent(this);
					}
				}
			}
		}
		public override void Switch(IAstTransformer transformer, out Node resultingNode)
		{
			Using thisNode = (Using)this;
			Using resultingTypedNode = thisNode;
			transformer.OnUsing(thisNode, ref resultingTypedNode);
			resultingNode = resultingTypedNode;
		}
	}
}
