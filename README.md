# poc-coveo-search-net

To run this application is required to have a Coveo account. If you want to index your own sources you have to create a trial account at coveo search organization, you will need to send a post with this Swagger UI https://platform.cloud.coveo.com/docs?api=Platform#!/Organizations/rest_organizations_post copy the OrganizationId from the response and then go to https://platform.cloud.coveo.com/login and log in with whatever you want, own coveo acc. or google acc. You will have to sync your acc with the organization id and then start adding sources and wait while coveo build them. For more information refer to https://docs.coveo.com/en/402/javascript-search-framework/javascript-search-framework-tutorial-5-configuring-your-own-search-endpoint.
You also need to save your API Key as explained at documentation linked before. After you already have sources indexed and the API Key you will need to update the Token and the URI specified in CoveoService.cs. 

Request template

URI = https://platform.cloud.coveo.com/rest/search/v2?organizationId=<MyOrganizationId>
TOKEN = <MyAccessToken>

Then you are ready to rebuild the application so it restores NuGet Packages and then run application (Set startup to poc-coveo-search). It will launch a Swagger UI.

For further experimentation there is a page where other query conditions that the Search API admit, here is the page: 
https://docs.coveo.com/en/1461/cloud-v2-developers/query-parameters
