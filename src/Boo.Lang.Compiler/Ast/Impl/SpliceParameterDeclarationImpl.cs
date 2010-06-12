#region license
// Copyright (c) 2009 Rodrigo B. de Oliveira (rbo@acm.org)
// All rights reserved.
// 
// Redistribution and use in source and binary forms, with or without modification,
// are permitted provided that the following conditions are met:
// 
//     * Redistributions of source code must retain the above copyright notice,
//     this list of conditions and the following disclaimer.
//     * Redistributions in binary form must reproduce the above copyright notice,
//     this list of conditions and the following disclaimer in the documentation
//     and/or other materials provided with the distribution.
//     * Neither the name of Rodrigo B. de Oliveira nor the names of its
//     contributors may be used to endorse or promote products derived from this
//     software without specific prior written permission.
// 
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
// ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
// WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
// DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE LIABLE
// FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL
// DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR
// SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER
// CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY,
// OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF
// THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
#endregion

//
// DO NOT EDIT THIS FILE!
//
// This file was generated automatically by astgen.boo.
//
namespace Boo.Lang.Compiler.Ast
{	
	using System.Collections;
	using System.Runtime.Serialization;
	
	[System.Serializable]
	public partial class SpliceParameterDeclaration : ParameterDeclaration
	{
		protected ParameterDeclaration _parameterDeclaration;

		protected Expression _nameExpression;


		[System.CodeDom.Compiler.GeneratedCodeAttribute("astgen.boo", "1")]
		new public SpliceParameterDeclaration CloneNode()
		{
			return (SpliceParameterDeclaration)Clone();
		}
		
		/// <summary>
		/// <see cref="Node.CleanClone"/>
		/// </summary>
		[System.CodeDom.Compiler.GeneratedCodeAttribute("astgen.boo", "1")]
		new public SpliceParameterDeclaration CleanClone()
		{
			return (SpliceParameterDeclaration)base.CleanClone();
		}

		[System.CodeDom.Compiler.GeneratedCodeAttribute("astgen.boo", "1")]
		override public NodeType NodeType
		{
			get
			{
				return NodeType.SpliceParameterDeclaration;
			}
		}

		[System.CodeDom.Compiler.GeneratedCodeAttribute("astgen.boo", "1")]
		override public void Accept(IAstVisitor visitor)
		{
			visitor.OnSpliceParameterDeclaration(this);
		}

		[System.CodeDom.Compiler.GeneratedCodeAttribute("astgen.boo", "1")]
		override public bool Matches(Node node)
		{	
			SpliceParameterDeclaration other = node as SpliceParameterDeclaration;
			if (null == other) return false;
			if (_name != other._name) return NoMatch("SpliceParameterDeclaration._name");
			if (!Node.Matches(_type, other._type)) return NoMatch("SpliceParameterDeclaration._type");
			if (_modifiers != other._modifiers) return NoMatch("SpliceParameterDeclaration._modifiers");
			if (!Node.AllMatch(_attributes, other._attributes)) return NoMatch("SpliceParameterDeclaration._attributes");
			if (!Node.Matches(_parameterDeclaration, other._parameterDeclaration)) return NoMatch("SpliceParameterDeclaration._parameterDeclaration");
			if (!Node.Matches(_nameExpression, other._nameExpression)) return NoMatch("SpliceParameterDeclaration._nameExpression");
			return true;
		}

		[System.CodeDom.Compiler.GeneratedCodeAttribute("astgen.boo", "1")]
		override public bool Replace(Node existing, Node newNode)
		{
			if (base.Replace(existing, newNode))
			{
				return true;
			}
			if (_type == existing)
			{
				this.Type = (TypeReference)newNode;
				return true;
			}
			if (_attributes != null)
			{
				Attribute item = existing as Attribute;
				if (null != item)
				{
					Attribute newItem = (Attribute)newNode;
					if (_attributes.Replace(item, newItem))
					{
						return true;
					}
				}
			}
			if (_parameterDeclaration == existing)
			{
				this.ParameterDeclaration = (ParameterDeclaration)newNode;
				return true;
			}
			if (_nameExpression == existing)
			{
				this.NameExpression = (Expression)newNode;
				return true;
			}
			return false;
		}

		[System.CodeDom.Compiler.GeneratedCodeAttribute("astgen.boo", "1")]
		override public object Clone()
		{
			SpliceParameterDeclaration clone = (SpliceParameterDeclaration)FormatterServices.GetUninitializedObject(typeof(SpliceParameterDeclaration));
			clone._lexicalInfo = _lexicalInfo;
			clone._endSourceLocation = _endSourceLocation;
			clone._documentation = _documentation;
			clone._entity = _entity;
			if (_annotations != null) clone._annotations = (Hashtable)_annotations.Clone();
		
			clone._name = _name;
			if (null != _type)
			{
				clone._type = _type.Clone() as TypeReference;
				clone._type.InitializeParent(clone);
			}
			clone._modifiers = _modifiers;
			if (null != _attributes)
			{
				clone._attributes = _attributes.Clone() as AttributeCollection;
				clone._attributes.InitializeParent(clone);
			}
			if (null != _parameterDeclaration)
			{
				clone._parameterDeclaration = _parameterDeclaration.Clone() as ParameterDeclaration;
				clone._parameterDeclaration.InitializeParent(clone);
			}
			if (null != _nameExpression)
			{
				clone._nameExpression = _nameExpression.Clone() as Expression;
				clone._nameExpression.InitializeParent(clone);
			}
			return clone;
		}

		[System.CodeDom.Compiler.GeneratedCodeAttribute("astgen.boo", "1")]
		override internal void ClearTypeSystemBindings()
		{
			_annotations = null;
			_entity = null;
			if (null != _type)
			{
				_type.ClearTypeSystemBindings();
			}
			if (null != _attributes)
			{
				_attributes.ClearTypeSystemBindings();
			}
			if (null != _parameterDeclaration)
			{
				_parameterDeclaration.ClearTypeSystemBindings();
			}
			if (null != _nameExpression)
			{
				_nameExpression.ClearTypeSystemBindings();
			}

		}
	

		[System.Xml.Serialization.XmlElement]
		[System.CodeDom.Compiler.GeneratedCodeAttribute("astgen.boo", "1")]
		public ParameterDeclaration ParameterDeclaration
		{
			get
			{

				return _parameterDeclaration;
			}

			set
			{
				if (_parameterDeclaration != value)
				{
					_parameterDeclaration = value;
					if (null != _parameterDeclaration)
					{
						_parameterDeclaration.InitializeParent(this);
					}
				}
			}

		}
		

		[System.Xml.Serialization.XmlElement]
		[System.CodeDom.Compiler.GeneratedCodeAttribute("astgen.boo", "1")]
		public Expression NameExpression
		{
			get
			{

				return _nameExpression;
			}

			set
			{
				if (_nameExpression != value)
				{
					_nameExpression = value;
					if (null != _nameExpression)
					{
						_nameExpression.InitializeParent(this);
					}
				}
			}

		}
		

	}
}

