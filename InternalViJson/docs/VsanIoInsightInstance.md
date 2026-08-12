# Vcenter.ViJson.OpenApi.Model.VsanIoInsightInstance

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RunName** | **string** | Run name of the ioinsight instance, which is specified when invoking *VsanIoInsightManager.StartIoInsight*  | 
**State** | **string** | State of the ioinsight instance, that is, ioinsight instance is in running or completed.  This attribute can be optional for ioinsight instance update operation.  See also *VsanIoInsightInstanceState_enum*.  | [optional] 
**StartTime** | **DateTime** | Start timestamp of the ioinsight instance.  This attribute can be optional for ioinsight instance update operation.  | [optional] 
**EndTime** | **DateTime** | End timestamp of the ioinsight instance.  This attribute is optional for either running ioinsight instance, or ioinsight instance update operation.  | [optional] 
**HostsIoInsightInfo** | [**List&lt;VsanHostIoInsightInfo&gt;**](VsanHostIoInsightInfo.md) | One or multiple ioinsights information along with the hosts, which belong to the ioinsight instance.  This attribute is optional for ioinsight instance update operation.  | [optional] 
**HostUuids** | **List&lt;string&gt;** | The uuid of hosts which are related to ioinsight instance.  | [optional] 
**VmUuids** | **List&lt;string&gt;** | The uuid of VMs which are related to ioinsight instance.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

