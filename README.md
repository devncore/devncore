## Intro

Whoever you are, wherever you live — glad you stopped by. 👋

I'm **Nicolas Corgier**, a male human being with flesh and bones (yes, still one of those).
Husband, father of two, and — the part that matters here — **professional embedded software developer** with 11 years of experience in various fields. 🔧

My core expertise is embedded C/C++ (STM32, Embedded Linux, Qt), but I keep the curiosity wider than the job title.

---

## What this space is for 🎯

Public repositories here serve a few clear purposes:
- Demonstrate and expand **code architecture skills**
- Experiment with **design patterns, libraries, and new techniques**
- Build things I find genuinely interesting

---

## How I work on a project 📐

1. Define the system: main stack, libraries, purpose, rough spec
2. Write basic specs before touching a keyboard
3. Code with intent — taking the time to apply proper coding rules
4. Set up **static analysis** with meaningful rule sets
5. Design **unit tests** (not as an afterthought)

---

## Working with Claude AI 🤖

I use Claude (VSCode extension) as a **force multiplier — not a code generator**.

Concretely, Claude helps with:
- **Code review** — a second pair of eyes that doesn't get tired
- **Architecture opinions** — I decide, but I like a good argument first
- **Doc generation** — first draft by Claude, always manually updated
- **Module scaffolding** — give it a precise prompt (API surface, constraints), get a skeleton, refine by hand

> ⚠️ **Every generated line is reviewed. I learn from it when I can. I fix it when I must.**

The goal is transparency: anyone reading my code should understand what I own, what I delegated, and why.

---

## Responsibilities 📋

| Concern | Me | Claude |
|---|---|---|
| Architecture & design decisions | ✅ (final call) | Consulted for opinions |
| Business logic & safety-critical code | ✅ | ❌ |
| Boilerplate, scaffolding, test stubs | Reviews & owns | Generates first draft |
| Documentation & inline comments | Reviews & owns | Generates first draft |
| Refactoring (non-critical paths) | Reviews & approves | Proposes & implements |
| Debug hypotheses | ✅ (final call) | Suggests candidates |
| Code review pass | ✅ (mandatory) | Assists |
| Commit messages | ✅ | Never |

**Rule of thumb**: Claude drafts, I own. If I can't explain every line in a code review, it doesn't ship.

---

## Workflow conventions ⚙️

- **Context first**: before any Claude prompt, I state the target (MCU, RTOS, constraints, failure modes). No context, no useful output.
- **Scope explicitly**: what's in scope *and* what's out of scope — both matter.
- **One concern per prompt**: refactor OR new feature OR tests. Never all at once.

---

## Why this document exists 💬

AI-assisted development is real and I use it. Pretending otherwise in a portfolio is dishonest.

This README is my answer to: *"How do you make sure you actually understand what you ship?"*

Clear ownership, explicit constraints, and a non-negotiable review gate.

---

*Last updated: March 2026*
