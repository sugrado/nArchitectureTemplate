﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace nArchitectureExtension.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class TemplateFiles {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal TemplateFiles() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("nArchitectureExtension.Resources.TemplateFiles", typeof(TemplateFiles).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to namespace {ApplicationNamespace}.Features.{PluralEntityName}.Constants
        ///{
        ///    public static class {EntityName}Messages
        ///    {
        ///       
        ///    }
        ///}.
        /// </summary>
        internal static string Constant {
            get {
                return ResourceManager.GetString("Constant", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using AutoMapper;
        ///using Core.Application.Pipelines.Authorization;
        ///using {ApplicationNamespace}.Features.{PluralEntityname}.Dtos;
        ///using {ApplicationNamespace}.Features.{PluralEntityname}.Rules;
        ///using {ApplicationNamespace}.Services.Repositories;
        ///using {EntityNamespace};
        ///using MediatR;
        ///
        ///namespace {ApplicationNamespace}.Features.{PluralEntityname}.Commands.Create{EntityName}
        ///{
        ///    public class Create{EntityName}Command : IRequest&lt;Created{EntityName}Dto&gt;,ISecuredRequest
        ///    {
        ///        {Properties}
        ///  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string CreateCommandTemplate {
            get {
                return ResourceManager.GetString("CreateCommandTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using FluentValidation;
        ///
        ///namespace {ApplicationNamespace}.Features.{PluralEntityName}.Commands.Create{EntityName}
        ///{
        ///    public class Create{EntityName}CommandValidator:AbstractValidator&lt;Create{EntityName}Command&gt;
        ///    {
        ///        public Create{EntityName}CommandValidator()
        ///        {
        ///        }
        ///    }
        ///}
        ///.
        /// </summary>
        internal static string CreateCommandValidor {
            get {
                return ResourceManager.GetString("CreateCommandValidor", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to namespace {ApplicationNamespace}.Features.{PluralEntityName}.Dtos
        ///{
        ///    public class Created{EntityName}Dto
        ///    {
        ///        {Properties}
        ///    }
        ///}.
        /// </summary>
        internal static string CreatedDto {
            get {
                return ResourceManager.GetString("CreatedDto", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using AutoMapper;
        ///using Core.Application.Pipelines.Authorization;
        ///using {ApplicationNamespace}.Features.{PluralEntityName}.Dtos;
        ///using {ApplicationNamespace}.Features.{PluralEntityName}.Rules;
        ///using {ApplicationNamespace}.Services.Repositories;
        ///using {EntityNamespace};
        ///using MediatR;
        ///
        ///namespace {ApplicationNamespace}.Features.{PluralEntityName}.Commands.Delete{EntityName}
        ///{
        ///    public class Delete{EntityName}Command:IRequest&lt;Deleted{EntityName}Dto&gt;,ISecuredRequest
        ///    {
        ///        {Properties}
        ///    [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string DeleteCommandTemplate {
            get {
                return ResourceManager.GetString("DeleteCommandTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using FluentValidation;
        ///
        ///namespace {ApplicationNamespace}.Features.{PluralEntityName}.Commands.Delete{EntityName}
        ///{
        ///    public class Delete{EntityName}CommandValidator:AbstractValidator&lt;Delete{EntityName}Command&gt;
        ///    {
        ///        public Delete{EntityName}CommandValidator()
        ///        {
        ///        }
        ///    }
        ///}
        ///.
        /// </summary>
        internal static string DeleteCommandValidator {
            get {
                return ResourceManager.GetString("DeleteCommandValidator", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to namespace {ApplicationNamespace}.Features.{PluralEntityName}.Dtos
        ///{
        ///    public class Deleted{EntityName}Dto
        ///    {
        ///        {Properties}
        ///    }
        ///}.
        /// </summary>
        internal static string DeletedDto {
            get {
                return ResourceManager.GetString("DeletedDto", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to namespace {ApplicationNamespace}.Features.{PluralEntityName}.Dtos
        ///{
        ///    public class {EntityName}Dto
        ///    {
        ///        {Properties}
        ///    }
        ///}.
        /// </summary>
        internal static string Dto {
            get {
                return ResourceManager.GetString("Dto", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using AutoMapper;
        ///using Core.Application.Pipelines.Authorization;
        ///using {ApplicationNamespace}.Features.{PluralEntityName}.Dtos;
        ///using {ApplicationNamespace}.Services.Repositories;
        ///using {EntityNamespace};
        ///using MediatR;
        ///using Microsoft.EntityFrameworkCore;
        ///
        ///namespace {ApplicationNamespace}.Features.{PluralEntityName}.Queries.GetById{EntityName}
        ///{
        ///    public class GetById{EntityName}Query:IRequest&lt;{EntityName}Dto&gt;,ISecuredRequest
        ///    {
        ///        public int Id { get; set; }
        ///        public string[] [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string GetByIdQuery {
            get {
                return ResourceManager.GetString("GetByIdQuery", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using AutoMapper;
        ///using Core.Application.Pipelines.Authorization;
        ///using Core.Application.Requests;
        ///using Core.Persistence.Dynamic;
        ///using Core.Persistence.Paging;
        ///using {ApplicationNamespace}.Features.{PluralEntityName}.Models;
        ///using {ApplicationNamespace}.Services.Repositories;
        ///using Kodlama.io.Devs.Domain.Entities;
        ///using MediatR;
        ///using {EntityNamespace};
        ///
        ///namespace {ApplicationNamespace}.Features.{PluralEntityName}.Queries.GetListByDynamic{EntityName}
        ///{
        ///    public class GetListByDynamic{Entity [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string GetListByDynamic {
            get {
                return ResourceManager.GetString("GetListByDynamic", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using AutoMapper;
        ///using Core.Application.Pipelines.Authorization;
        ///using Core.Application.Requests;
        ///using Core.Persistence.Paging;
        ///using {ApplicationNamespace}.Features.{PluralEntityName}.Models;
        ///using {ApplicationNamespace}.Services.Repositories;
        ///using {EntityNamespace};
        ///using MediatR;
        ///using Microsoft.EntityFrameworkCore;
        ///
        ///namespace {ApplicationNamespace}.Features.{PluralEntityName}.Queries.GetList{EntityName}
        ///{
        ///    public class GetList{EntityName}Query:IRequest&lt;{EntityName}ListModel&gt;,ISecuredRe [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string GetListQuery {
            get {
                return ResourceManager.GetString("GetListQuery", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using Core.Persistence.Repositories;
        ///using {EntityNamespace};
        ///
        ///namespace {ApplicationNamespace}.Services.Repositories
        ///{
        ///    public interface I{EntityName}Repository : IAsyncRepository&lt;{EntityName}&gt;, IRepository&lt;{EntityName}&gt; { }
        ///}
        ///.
        /// </summary>
        internal static string InterfaceRepository {
            get {
                return ResourceManager.GetString("InterfaceRepository", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using AutoMapper;
        ///using Core.Persistence.Paging;
        ///using {ApplicationNamespace}.Features.{PluralEntityName}.Commands.Create{EntityName};
        ///using {ApplicationNamespace}.Features.{PluralEntityName}.Commands.Delete{EntityName};
        ///using {ApplicationNamespace}.Features.{PluralEntityName}.Commands.Update{EntityName};
        ///using {ApplicationNamespace}.Features.{PluralEntityName}.Dtos;
        ///using {ApplicationNamespace}.Features.{PluralEntityName}.Models;
        ///using {EntityNamespace};
        ///
        ///namespace {ApplicationNamespace}.Features. [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string MappingProfile {
            get {
                return ResourceManager.GetString("MappingProfile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using Core.Persistence.Paging;
        ///using {ApplicationNamespace}.Features.{PluralEntityName}.Dtos;
        ///
        ///namespace {ApplicationNamespace}.Features.{PluralEntityName}.Models
        ///{
        ///    public class {EntityName}ListModel:BasePageableModel
        ///    {
        ///        public IList&lt;{EntityName}Dto&gt; Items { get; set; }
        ///    }
        ///}.
        /// </summary>
        internal static string Model {
            get {
                return ResourceManager.GetString("Model", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using Core.Persistence.Repositories;
        ///using {ApplicationNamespace}.Contexts;
        ///using {ApplicationNamespace}.Services.Repositories;
        ///using {EntityNamespace};
        ///
        ///namespace {PersistenceNamespace}.Repositories
        ///{
        ///    public class {EntityName}Repository : EfRepositoryBase&lt;{EntityName}, BaseDbContext&gt;, I{EntityName}Repository
        ///    {
        ///        public {EntityName}Repository(BaseDbContext context) : base(context) { }
        ///    }
        ///}.
        /// </summary>
        internal static string Repository {
            get {
                return ResourceManager.GetString("Repository", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to namespace {ApplicationNamespace}.Features.{PluralEntityName}.Rules
        ///{
        ///    public class {EntityName}BusinessRule
        ///    {
        ///       
        ///    }
        ///}
        ///.
        /// </summary>
        internal static string Rule {
            get {
                return ResourceManager.GetString("Rule", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using AutoMapper;
        ///using Core.Application.Pipelines.Authorization;
        ///using {ApplicationNamespace}.Features.{PluralEntityName}.Dtos;
        ///using {ApplicationNamespace}.Features.{PluralEntityName}.Rules;
        ///using {ApplicationNamespace}.Services.Repositories;
        ///using {EntityNamespace};
        ///using MediatR;
        ///
        ///namespace {ApplicationNamespace}.Features.{PluralEntityName}.Commands.Update{EntityName}
        ///{
        ///    public class Update{EntityName}Command : IRequest&lt;Updated{EntityName}Dto&gt;, ISecuredRequest
        ///    {
        ///        {Properties}
        /// [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string UpdateCommandTemplate {
            get {
                return ResourceManager.GetString("UpdateCommandTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using FluentValidation;
        ///
        ///namespace {ApplicationNamespace}.Features.{PluralEntityName}.Commands.Update{EntityName}
        ///{
        ///    public class Update{EntityName}CommandValidator:AbstractValidator&lt;Update{EntityName}Command&gt;
        ///    {
        ///        public Update{EntityName}CommandValidator()
        ///        {
        ///        }
        ///    }
        ///}
        ///.
        /// </summary>
        internal static string UpdateCommandValidator {
            get {
                return ResourceManager.GetString("UpdateCommandValidator", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to namespace {ApplicationNamespace}.Features.{PluralEntityName}.Dtos
        ///{
        ///    public class Updated{EntityName}Dto
        ///    {
        ///        {Properties}
        ///    }
        ///}.
        /// </summary>
        internal static string UpdatedDto {
            get {
                return ResourceManager.GetString("UpdatedDto", resourceCulture);
            }
        }
    }
}