// This file is automatically generated by ABP framework to use MVC Controllers from CSharp
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Http.Client.ClientProxying;
using Volo.Abp.Http.Modeling;
using Volo.CmsKit.Admin.Comments;

// ReSharper disable once CheckNamespace
namespace Volo.CmsKit.Admin.Comments;

[Dependency(ReplaceServices = true)]
[ExposeServices(typeof(ICommentApprovedSettingService), typeof(CommentApprovedAdminClientProxy))]
public partial class CommentApprovedAdminClientProxy : ClientProxyBase<ICommentApprovedSettingService>, ICommentApprovedSettingService
{
    public virtual async Task CreateCommentApprovedStateAsync(bool isApproved)
    {
        await RequestAsync(nameof(CreateCommentApprovedStateAsync), new ClientProxyRequestTypeValue
        {
            { typeof(bool), isApproved }
        });
    }

    public virtual async Task<bool?> GetAsync()
    {
        return await RequestAsync<bool?>(nameof(GetAsync));
    }
}
