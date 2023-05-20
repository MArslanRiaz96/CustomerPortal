import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'CustomerPortal',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44341/',
    redirectUri: baseUrl,
    clientId: 'CustomerPortal_App',
    responseType: 'code',
    scope: 'offline_access CustomerPortal',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44374',
      rootNamespace: 'CustomerPortal',
    },
  },
} as Environment;
