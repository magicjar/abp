import { Injector, inject, provideAppInitializer } from '@angular/core';
import { DOCUMENT } from '@angular/common';
import { SessionStateService } from '../services/session-state.service';
import { COOKIE_LANGUAGE_KEY } from '../tokens/cookie-language-key.token';

export function setLanguageToCookie() {
  const injector = inject(Injector);
  const sessionState = injector.get(SessionStateService);
  const document = injector.get(DOCUMENT);
  const cookieLanguageKey = injector.get(COOKIE_LANGUAGE_KEY);
  sessionState.getLanguage$().subscribe(language => {
    const cookieValue = encodeURIComponent(`c=${language}|uic=${language}`);
    document.cookie = `${cookieLanguageKey}=${cookieValue}`;
  });
}

export const CookieLanguageProvider = provideAppInitializer(() => {
  setLanguageToCookie();
});
