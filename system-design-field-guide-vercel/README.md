# System Design Interview Field Guide

A Vercel-native interactive application covering all 28 cases in `liquidslr/system-design-notes`.

## Features

- Learn, Interview, Rapid Review, and Mock modes
- Search, categories, progress, bookmarks, notes, and mock history
- Capacity calculator and print-friendly case sheets
- Context-aware deterministic local coach
- Optional hosted OpenAI tutor through `OPENAI_API_KEY`

## Deploy

Use `system-design-field-guide-vercel` as the Vercel project root. No environment variable is required for the complete local-coach experience.

Optional variables:

- `OPENAI_API_KEY`: enables the hosted interview tutor
- `OPENAI_MODEL`: defaults to `gpt-5.6-terra`

User learning state is stored in browser `localStorage` in the Vercel edition.
