# Vcenter.ViJson.OpenApi.Model.VsanClusterHealthTest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TestId** | **string** | A unique ID for this test (i.e., In the vsphere web client, this is used as a ID for composing the AskVmware link, for example: http://www.vmware.com/esx/support/askvmware/index.php?eventtype&#x3D;&amp;lt;id&amp;gt;&amp;amp;language&#x3D;en\\_US).  | [optional] 
**TestName** | **string** | The name for this health test.  | [optional] 
**TestDescription** | **string** | The full test description.  | [optional] 
**TestShortDescription** | **string** | The short test description.  | [optional] 
**TestHealthyEntities** | **int** | The number of entities considered healthy in the context of the current test.  Each test can set this field to the number of entities that are heatlhy in the context of its execution. For example if the test examines the connectivity state of the hosts, the healthy entities in its context are the \&quot;connected\&quot; hosts. This field is optional as not all tests can have \&quot;healthy\&quot; objects. An example for such tests are the tests that contain only errors. In such context there is no \&quot;healthy\&quot; entity so the test should leave this field unset.  | [optional] 
**TestAllEntities** | **int** | The number of entities examined by the current test.  Each test can set this field to the number of examined entities. For example if the test checks the connectivity of the hosts, this field should be set to the number of hosts that are being tested.  | [optional] 
**TestHealth** | **string** | The test result enumeration.  The possible values are &#39;green&#39;, &#39;yellow&#39;, &#39;red&#39;, &#39;unknown&#39;, or &#39;info&#39;.  | [optional] 
**TestDetails** | [**List&lt;VsanClusterHealthResultBase&gt;**](VsanClusterHealthResultBase.md) | The test result data.  Each data item include the UI presentation structure and the actual value.  | [optional] 
**TestActions** | [**List&lt;VsanClusterHealthAction&gt;**](VsanClusterHealthAction.md) | The actions needed by user for potential vSAN health problem.  | [optional] 
**HistoricalResults** | [**List&lt;VsanHistoricalHealthTest&gt;**](VsanHistoricalHealthTest.md) | The historical check results for this test.  | [optional] 
**TestCorrelation** | [**VsanHealthCorrelation**](VsanHealthCorrelation.md) | The health correlation for the current health test  | [optional] 
**ReducedScore** | **int** | The reduced health score when it is not green.  It will be 0 if it&#39;s green.  | [optional] 
**Category** | **string** | The health category of this health test when it&#39;s not green.  Notice the same health test may belong to the different category according to its actual health status since it may have different user impact.  See also *VsanClusterHealthCategoryEnum_enum*.  | [optional] 
**RiskIfNotFix** | **string** | The potential risk if this vSAN health warning is not resolved from user perspective.  The main purpose for this field is to let user understand the possible impact for this health finding and then decide the proper remediation plan.  | [optional] 
**LastStatusChangeTime** | **DateTime** | The last time when the health status was changed.  For example, if the current health status is green, then it will be the last time when the health status was changed from non-green status and vice versa. It will be unset if the health status has never been changed.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

