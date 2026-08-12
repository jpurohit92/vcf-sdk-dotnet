# Vcenter.ViJson.OpenApi.Model.HostActiveDirectory

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ChangeOperation** | **string** | Configuration change operation to apply to the host.  You can specify the following values: - *add*:   Add the host to the domain. The ESX Server will use the   *HostActiveDirectorySpec* information   (domain, account user name and password) to call   *HostActiveDirectoryAuthentication.JoinDomain_Task* and optionally   configure smart card authentication by calling   *HostActiveDirectoryAuthentication.DisableSmartCardAuthentication*   and replacing the trust anchors with those provided. - *remove*:   Remove the host from its current domain.   The ESX Server will call   *HostActiveDirectoryAuthentication.LeaveCurrentDomain_Task*, specifying   &lt;code&gt;True&lt;/code&gt; for the &lt;code&gt;force&lt;/code&gt; parameter to delete   existing permissions.   *HostActiveDirectoryAuthentication.DisableSmartCardAuthentication*   is also called if smart card authentication is enabled and trust   anchors are removed.    See also *HostConfigChangeOperation_enum*.  | 
**Spec** | [**HostActiveDirectorySpec**](HostActiveDirectorySpec.md) | Active Directory domain access information (domain and account user name and password).  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

