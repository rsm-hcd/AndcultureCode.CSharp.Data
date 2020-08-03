<a name='assembly'></a>
# AndcultureCode.CSharp.Data

## Contents

- [IApplicationBuilderExtensions](#T-AndcultureCode-CSharp-Data-Extensions-IApplicationBuilderExtensions 'AndcultureCode.CSharp.Data.Extensions.IApplicationBuilderExtensions')
  - [ConfigureDatabase\`\`1(app,serviceProvider,migrate,seeds)](#M-AndcultureCode-CSharp-Data-Extensions-IApplicationBuilderExtensions-ConfigureDatabase``1-Microsoft-AspNetCore-Builder-IApplicationBuilder,System-IServiceProvider,System-Boolean,AndcultureCode-CSharp-Core-SeedsBase{``0}- 'AndcultureCode.CSharp.Data.Extensions.IApplicationBuilderExtensions.ConfigureDatabase``1(Microsoft.AspNetCore.Builder.IApplicationBuilder,System.IServiceProvider,System.Boolean,AndcultureCode.CSharp.Core.SeedsBase{``0})')
- [IDatabaseContext](#T-AndcultureCode-CSharp-Data-Interfaces-IDatabaseContext 'AndcultureCode.CSharp.Data.Interfaces.IDatabaseContext')
  - [Database](#P-AndcultureCode-CSharp-Data-Interfaces-IDatabaseContext-Database 'AndcultureCode.CSharp.Data.Interfaces.IDatabaseContext.Database')

<a name='T-AndcultureCode-CSharp-Data-Extensions-IApplicationBuilderExtensions'></a>
## IApplicationBuilderExtensions `type`

##### Namespace

AndcultureCode.CSharp.Data.Extensions

##### Summary

Infrastructure Data IApplicationBuilder Extensions

<a name='M-AndcultureCode-CSharp-Data-Extensions-IApplicationBuilderExtensions-ConfigureDatabase``1-Microsoft-AspNetCore-Builder-IApplicationBuilder,System-IServiceProvider,System-Boolean,AndcultureCode-CSharp-Core-SeedsBase{``0}-'></a>
### ConfigureDatabase\`\`1(app,serviceProvider,migrate,seeds) `method`

##### Summary

Performs application startup related database configuration tasks

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| app | [Microsoft.AspNetCore.Builder.IApplicationBuilder](#T-Microsoft-AspNetCore-Builder-IApplicationBuilder 'Microsoft.AspNetCore.Builder.IApplicationBuilder') |  |
| serviceProvider | [System.IServiceProvider](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IServiceProvider 'System.IServiceProvider') |  |
| migrate | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Should outstanding code-first migrations be run? |
| seeds | [AndcultureCode.CSharp.Core.SeedsBase{\`\`0}](#T-AndcultureCode-CSharp-Core-SeedsBase{``0} 'AndcultureCode.CSharp.Core.SeedsBase{``0}') | Optional instance of seeds to run |

<a name='T-AndcultureCode-CSharp-Data-Interfaces-IDatabaseContext'></a>
## IDatabaseContext `type`

##### Namespace

AndcultureCode.CSharp.Data.Interfaces

##### Summary

Database specific context

<a name='P-AndcultureCode-CSharp-Data-Interfaces-IDatabaseContext-Database'></a>
### Database `property`

##### Summary

Provides access to database related information and operations for this context.
///
